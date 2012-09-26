// ModeladoCBC.cpp: archivo de proyecto principal.

#include "stdafx.h"
#include "Principal.h"

using namespace ModeladoCBC;

[STAThreadAttribute]
int main(array<System::String ^> ^args)
{
	// Habilitar los efectos visuales de Windows XP antes de crear ningún control
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false); 

	// Crear la ventana principal y ejecutarla
	Application::Run(gcnew Form1());
	return 0;
}
