using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Modelos;
using Facade.Helpers;
namespace Facade.Modulos.Sub_Modulos.RRHH
{
    public class Vacaciones
    {

        public static List <Empleados_Vacaciones> listaEmpleados_Vacaciones= new List<Empleados_Vacaciones>();
       
        public void SetVacaiones(List<Empleados> ListaEmpleados)
        {

            Empleados empleado;

            string identificador = "";

            Listar.Listar_Empleados(ListaEmpleados);

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

                Console.WriteLine("Presione la tecla para asignar vacaciones");

                Console.ReadKey();
                Console.Clear();

                DateTime fechainicio = DateTime.Parse(Inputs.Input_String("Ingrese la fecha inicio: "));
                DateTime fechafin = DateTime.Parse(Inputs.Input_String("Ingrese la fecha fin: "));
                listaEmpleados_Vacaciones.Add(new Empleados_Vacaciones {Cedula=empleado.Cedula,FechaInicio=fechainicio, FechaFin=fechafin});
                Console.WriteLine("Exito");

                Console.ReadKey();

            }
            catch (Exception)
            {

                Console.WriteLine("No existe este empleado...Presione cualquier tecla para avanzar");
                Console.ReadKey();


                Console.WriteLine("Quiere intentarlo de nuevo? " +
                    "\n1-Si 2-No");

                int seleccion = Inputs.Input_int("Selecccion: ");

                if (seleccion == 1)
                {
                    SetVacaiones(ListaEmpleados);

                }

                Console.WriteLine("Saliendo...Presione la tecla para salir");

                Console.ReadKey();

                Console.Clear();



            }


        }
    }
}
