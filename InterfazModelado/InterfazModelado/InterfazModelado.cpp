#include "OsiClp/OsiClpSolverInterface.hpp"
#include "CbcModel.hpp"
#include "CoinModel.hpp"
#include "Principal.h"

#include <cstdio>

using namespace PrincipalForm;

int main() {
  const int numcols = 3;
  const int numrows = 1;
  double obj[] = { 1.0, 1.0, 1.0}; // obj: Max x0 + x1
  
  // Column-major sparse "A" matrix: x0 + 2 x1 + x2<= 3.9
  //                                A x0+ B x1 + x2<= 3.9
  int start[] = {0, 1, 2, 3};      // where in index columns start (?)
  int index[] = {0, 0, 0};         // row indexs for the columns
  double values[] = {1.0, 1.0, 2.0}; // the values in the sparse matrix (values of the constants)
  double rowlb[]  = {0.0}; //lower bound
  double rowub[]  = {100.0}; //upper bound

  //          0 <= x0 <= 10 and integer
  //          0 <= x1 <= 10
  //          0 <= x2 <= 10
  double collb[] = {10.0, 10.0, 10.0};
  double colub[] = {50.0, 50.0, 40.0};
	
  OsiClpSolverInterface model;
  model.loadProblem(numcols, numrows, start, index, values, 
                    collb, colub, obj, rowlb, rowub);
  model.setInteger(0); // Sets x0 to integer
  model.setObjSense(-1.0); // Maximise

  CbcModel solver(model);
  solver.branchAndBound();
  bool optimal = solver.isProvenOptimal();
  const double *val = solver.getColSolution();
  printf("Solution %g %g %g\n", val[0], val[1], val[2]);

  return 0;
}