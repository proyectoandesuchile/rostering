#include "InterfazModelado.h"

#pragma once

namespace PrincipalForm {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de MyForm
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
	private: array<System::Windows::Forms::DataGridViewTextBoxColumn^>  ^ColumnArr; //arreglo de columnas no inicializado
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Label^  labelResultado;
	private: System::Windows::Forms::DataGridView^  TablaCSV;
	



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
			this->labelResultado = (gcnew System::Windows::Forms::Label());
			this->TablaCSV = (gcnew System::Windows::Forms::DataGridView());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->TablaCSV))->BeginInit();
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(295, 358);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 23);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Abrir CSV";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Principal::AbrirArchivoClick);
			// 
			// labelResultado
			// 
			this->labelResultado->AutoSize = true;
			this->labelResultado->Location = System::Drawing::Point(307, 432);
			this->labelResultado->Name = L"labelResultado";
			this->labelResultado->Size = System::Drawing::Size(13, 13);
			this->labelResultado->TabIndex = 1;
			this->labelResultado->Text = L"0";
			// 
			// TablaCSV
			// 
			this->TablaCSV->AllowUserToDeleteRows = false;
			this->TablaCSV->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->TablaCSV->Location = System::Drawing::Point(13, 13);
			this->TablaCSV->Name = L"TablaCSV";
			this->TablaCSV->Size = System::Drawing::Size(677, 348);
			this->TablaCSV->TabIndex = 2;
			//this->TablaCSV->CreateColumnsInstance;
			// 
			// Principal
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(748, 496);
			this->Controls->Add(this->TablaCSV);
			this->Controls->Add(this->labelResultado);
			this->Controls->Add(this->button1);
			this->Name = L"Principal";
			this->Text = L"MyForm";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->TablaCSV))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void AbrirArchivoClick(System::Object^  sender, System::EventArgs^  e) {
			 int a=0;
			 try{
				 ifstream myfile;
				 std::string line;
				 myfile.open ("Txt/meh.txt"); //directorio debe existir, agrego al final
				 
				 getline(myfile, line);
				 

				 char * cstr, *p; //auxiliares para leer y tokenizar
				 
				 cstr = new char [line.size()+1];
				 strcpy (cstr, line.c_str());
				 int i= std::count(line.begin(), line.end(), ',');
				 i++;
				 /*
				 creamos un arreglo para los nombres de los atributos, y otro para los labels
				 */
				 std::string* atributos= new std::string[i];
				 
				 array<System::Windows::Forms::Label^>  ^LabelArr=gcnew array<System::Windows::Forms::Label^>(i);


				 p=strtok (cstr,",");//tokeniza
				 int aux=0;
				 while (p!=NULL) //mientras hayan cosas
				 {
					//cout << p << endl;
					atributos[aux++]=p;
					p=strtok(NULL,","); //tokeniza
				 }

				 /*inicializamos el arreglo de labels*/

				 /*for(int j=0; j<i ;j++){
					LabelArr[j]= gcnew System::Windows::Forms::Label();
					//cout<<atributos[j].c_str()<<endl;
					LabelArr[j]->Text = gcnew String(atributos[j].c_str());
				 }*/

				 /*inicializamos el arreglo de columnas*/
				 ColumnArr= gcnew array<System::Windows::Forms::DataGridViewTextBoxColumn^>(i);
				 for(int j=0; j<i; j++){
					ColumnArr[j]=(gcnew System::Windows::Forms::DataGridViewTextBoxColumn());//esto crea una nueva columna
					this->ColumnArr[j]->HeaderText= gcnew String(atributos[j].c_str());//texto del titulo
					this->ColumnArr[j]->Name=gcnew String(atributos[j].c_str());//nombre de la columna (para efectos de donde agregar datos)
					this->TablaCSV->Columns->Add(ColumnArr[j]);
				 }
				 labelResultado -> Text = gcnew String(line.c_str());
				 
				 delete[] cstr; 
				 delete[] p;
				 delete[] atributos;

				 myfile.close();
			 }
			 catch (...){
				 labelResultado->Text = "FAIL";
			 }
			 
			 }
	};
}
