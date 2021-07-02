using System;
using System.Collections.Generic;
using Facade.Modelos;
using Facade.Helpers;



namespace Facade.Modulos.Sub_Modulos
{
    public class Control_Empleados
    {
       

        public void Contratar(List<Empleados> ListaEmpleados)
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

            ListaEmpleados.Add(oEmpleado);

        }

        public void Desvincular(List<Empleados> ListaEmpleados)
        {
            Empleados empleado;

            string identificador="";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("Cedula: "+ListaEmpleados[i].Cedula);
                Console.WriteLine("Nombre: "+ListaEmpleados[i].Nombres);
                Console.WriteLine("Cargo: "+ListaEmpleados[i].Cargo);
                Console.WriteLine("Departamento: "+ListaEmpleados[i].Departamento);
                Console.WriteLine("Salario Bruto: "+ListaEmpleados[i].SalarioBruto);
                Console.WriteLine("******************************************");

            }

            identificador = Inputs.Input_String("Ingrese el identificador del empleado");

            try
            {
                empleado = ListaEmpleados.Find(x => x.Cedula == identificador);

                Console.WriteLine("******************************************");
                Console.WriteLine("Cedula: " + empleado.Cedula);
                Console.WriteLine("Nombre: " + empleado.Nombres);
                Console.WriteLine("Cargo: " + empleado.Cargo);
                Console.WriteLine("Departamento: " + empleado.Departamento);
                Console.WriteLine("Salario Bruto: " + empleado.SalarioBruto);
                Console.WriteLine("******************************************");

                Console.WriteLine("Presione la tecla para borrarlo");

                Console.ReadKey();
                Console.Clear();
                ListaEmpleados.Remove(empleado);
                Console.WriteLine("Exito");

                Console.ReadKey();

            }
            catch (Exception)
            {

                Console.WriteLine("No existe este empleado...Presione cualquier tecla para avanzar");
                Console.ReadKey();


                Console.WriteLine("Quiere intentarlo de nuevo? " +
                    "\n1-Si 2-No");

                int seleccion= Inputs.Input_int("Selecccion: ");

                if (seleccion == 1)
                {
                    Desvincular(ListaEmpleados);

                }

                Console.WriteLine("Saliendo...Presione la tecla para salir");

                Console.ReadKey();

                Console.Clear();
                
                

            }

          


        }

    }
}
