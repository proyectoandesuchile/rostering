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
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Label^  labelResultado;
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
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(102, 109);
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
			this->labelResultado->Location = System::Drawing::Point(102, 153);
			this->labelResultado->Name = L"labelResultado";
			this->labelResultado->Size = System::Drawing::Size(13, 13);
			this->labelResultado->TabIndex = 1;
			this->labelResultado->Text = L"0";
			// 
			// Principal
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(284, 262);
			this->Controls->Add(this->labelResultado);
			this->Controls->Add(this->button1);
			this->Name = L"Principal";
			this->Text = L"MyForm";
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
				 String^ meh = gcnew String(line.c_str());
				 
				 labelResultado->Text = meh;
				 myfile.close();
			 }
			 catch (...){
				 labelResultado->Text = "FAIL";
			 }
			 
			 }
	};
}
