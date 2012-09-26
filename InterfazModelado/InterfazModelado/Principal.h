#include "InterfazModelado.h"
#include <sstream>
#include <string>

#pragma once

namespace PrincipalForm {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de Principal
	/// </summary>
	public ref class Principal : public System::Windows::Forms::Form
	{
	public:
		Principal(void)
		{
			InitializeComponent();
			//
			//TODO: agregar código de constructor aquí
			//
		}

	protected:
		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		~Principal()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::TextBox^  numRows;
	private: System::Windows::Forms::TextBox^  numCols;
	private: System::Windows::Forms::TextBox^  Value1;



	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::TextBox^  Value2;
	private: System::Windows::Forms::TextBox^  Value3;
	private: System::Windows::Forms::TextBox^  lowerB;




	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::TextBox^  upperB;

	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::Label^  labelValue1;
	private: System::Windows::Forms::Label^  labelValue2;
	private: System::Windows::Forms::Label^  labelValue3;



	protected: 

	private:
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->numRows = (gcnew System::Windows::Forms::TextBox());
			this->numCols = (gcnew System::Windows::Forms::TextBox());
			this->Value1 = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->Value2 = (gcnew System::Windows::Forms::TextBox());
			this->Value3 = (gcnew System::Windows::Forms::TextBox());
			this->lowerB = (gcnew System::Windows::Forms::TextBox());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->upperB = (gcnew System::Windows::Forms::TextBox());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->labelValue1 = (gcnew System::Windows::Forms::Label());
			this->labelValue2 = (gcnew System::Windows::Forms::Label());
			this->labelValue3 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(136, 283);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 23);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Run";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Principal::button1_Click);
			// 
			// numRows
			// 
			this->numRows->Location = System::Drawing::Point(56, 64);
			this->numRows->Name = L"numRows";
			this->numRows->Size = System::Drawing::Size(100, 20);
			this->numRows->TabIndex = 1;
			this->numRows->Text = L"0";
			// 
			// numCols
			// 
			this->numCols->Location = System::Drawing::Point(56, 38);
			this->numCols->Name = L"numCols";
			this->numCols->Size = System::Drawing::Size(100, 20);
			this->numCols->TabIndex = 2;
			this->numCols->Text = L"0";
			// 
			// Value1
			// 
			this->Value1->Location = System::Drawing::Point(56, 91);
			this->Value1->Name = L"Value1";
			this->Value1->Size = System::Drawing::Size(100, 20);
			this->Value1->TabIndex = 3;
			this->Value1->Text = L"0";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(162, 67);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(49, 13);
			this->label1->TabIndex = 4;
			this->label1->Text = L"numrows";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(162, 41);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(46, 13);
			this->label2->TabIndex = 5;
			this->label2->Text = L"numcols";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(162, 94);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(53, 13);
			this->label3->TabIndex = 6;
			this->label3->Text = L"constants";
			// 
			// Value2
			// 
			this->Value2->Location = System::Drawing::Point(56, 118);
			this->Value2->Name = L"Value2";
			this->Value2->Size = System::Drawing::Size(100, 20);
			this->Value2->TabIndex = 7;
			this->Value2->Text = L"0";
			// 
			// Value3
			// 
			this->Value3->Location = System::Drawing::Point(56, 145);
			this->Value3->Name = L"Value3";
			this->Value3->Size = System::Drawing::Size(100, 20);
			this->Value3->TabIndex = 8;
			this->Value3->Text = L"0";
			// 
			// lowerB
			// 
			this->lowerB->Location = System::Drawing::Point(56, 171);
			this->lowerB->Name = L"lowerB";
			this->lowerB->Size = System::Drawing::Size(100, 20);
			this->lowerB->TabIndex = 9;
			this->lowerB->Text = L"0";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(162, 174);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(38, 13);
			this->label4->TabIndex = 10;
			this->label4->Text = L"lowerb";
			// 
			// upperB
			// 
			this->upperB->Location = System::Drawing::Point(56, 198);
			this->upperB->Name = L"upperB";
			this->upperB->Size = System::Drawing::Size(100, 20);
			this->upperB->TabIndex = 11;
			this->upperB->Text = L"0";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(162, 201);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(40, 13);
			this->label5->TabIndex = 12;
			this->label5->Text = L"upperb";
			// 
			// labelValue1
			// 
			this->labelValue1->AutoSize = true;
			this->labelValue1->Location = System::Drawing::Point(250, 94);
			this->labelValue1->Name = L"labelValue1";
			this->labelValue1->Size = System::Drawing::Size(35, 13);
			this->labelValue1->TabIndex = 13;
			this->labelValue1->Text = L"label6";
			// 
			// labelValue2
			// 
			this->labelValue2->AutoSize = true;
			this->labelValue2->Location = System::Drawing::Point(250, 121);
			this->labelValue2->Name = L"labelValue2";
			this->labelValue2->Size = System::Drawing::Size(35, 13);
			this->labelValue2->TabIndex = 14;
			this->labelValue2->Text = L"label7";
			// 
			// labelValue3
			// 
			this->labelValue3->Location = System::Drawing::Point(250, 148);
			this->labelValue3->Name = L"labelValue3";
			this->labelValue3->Size = System::Drawing::Size(35, 13);
			this->labelValue3->TabIndex = 15;
			this->labelValue3->Text = L"label8";
			// 
			// Principal
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(347, 392);
			this->Controls->Add(this->labelValue3);
			this->Controls->Add(this->labelValue2);
			this->Controls->Add(this->labelValue1);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->upperB);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->lowerB);
			this->Controls->Add(this->Value3);
			this->Controls->Add(this->Value2);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->Value1);
			this->Controls->Add(this->numCols);
			this->Controls->Add(this->numRows);
			this->Controls->Add(this->button1);
			this->Name = L"Principal";
			this->Text = L"Inicio";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
				 //int resultado = apretarBoton();
				 
				 //obtener valores desde formulario.
				 int numcols= Convert::ToInt32(numCols->Text);
				 int numrows= Convert::ToInt32(numRows->Text);
				 double value1= Convert::ToDouble(Value1->Text);
				 double value2= Convert::ToDouble(Value2->Text);
				 double value3= Convert::ToDouble(Value3->Text);
				 int lowerb= Convert::ToDouble(lowerB->Text);
				 int upperb= Convert::ToDouble(upperB->Text);
				 //fin

				 double *resultado = apretarBoton2(numcols, numrows, value1, value2, value3, lowerb, upperb);
				 //double *resultado = apretarBoton2();
				 double a=resultado[0];
				 double b=resultado[1];
				 double c=resultado[2];
				 printf(" I GET %g %g %g\n", resultado[0], resultado[1], resultado[2]);
				
				

				 //this->textBox1->Text= Convert::ToString(resultado[0]) +" "+ Convert::ToString(resultado[1])+ " "+Convert::ToString(resultado[2]);

				 this->labelValue1->Text = Convert::ToString(a);
				 this->labelValue2->Text = Convert::ToString(b);//Convert::ToString(resultado[1]);
				 this->labelValue3->Text = Convert::ToString(c);//Convert::ToString(resultado[2]);

			 }
	};
}
