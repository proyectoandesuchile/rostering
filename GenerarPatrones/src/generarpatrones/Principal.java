package generarpatrones;
import java.io.*;

public class Principal {
        
      
    public static void main(String[] args) {
        //generaTodos los patrones
        GenerarPatrones patrones= new GenerarPatrones(3,7);
        //System.out.println(patrones.getTodos());
        //System.out.println(patrones.encontrarSecuencia("0,0"));
        //String nombres[]=separar(patrones.encontrarSecuencia(",0,0"));
        //patrones.eliminar(nombres);    
        //System.out.println("Post-eliminacion");
        //System.out.println(patrones.getTodos());
    }
    
    public static String[] separar(String a){
        return a.split(",");
    }
}
