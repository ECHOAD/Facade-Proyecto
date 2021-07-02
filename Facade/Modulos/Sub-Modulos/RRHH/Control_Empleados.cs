using System;
using System.Collections.Generic;
using Facade.Modelos;
using Facade.Helpers;


namespace Facade.Modulos.Sub_Modulos
{
    public class Control_Empleados
    {
        public  void Contratar(List<Empleados> algo)
        {
            Empleados oEmpleado = new Empleados();

            Console.WriteLine("Apartado de Contratar.. Presione cualquier tecla para avanzar a ingresar los datos del Empleado");
            Console.ReadKey();
            Console.Clear();


            oEmpleado.Cedula = Inputs.Input_String("Ingrese la Cedula: ");
            oEmpleado.Nombres = Inputs.Input_String("Ingrese el Nombre: ");
            oEmpleado.Cargo = Inputs.Input_String("Ingrese el Cargo: ");
            oEmpleado.Departamento = Inputs.Input_String("Ingrese el Departamento: ");
            oEmpleado.SalarioBruto = Inputs.Input_double("Ingrese el Salario Bruto");





        }

    }
}
