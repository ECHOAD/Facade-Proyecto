using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Modelos;
using Facade.Helpers;

namespace Facade.Modulos.Sub_Modulos.Nomina
{

    public class AccionPersonal
    {
        private static List<Empleado_AccionPersonal> listaEmpleados_AccionPersonal = new List<Empleado_AccionPersonal>();

        public void SetIncentivo(List<Empleados> ListaEmpleados)
        {

            Empleados empleado;

            string identificador = "";

            Listar.Listar_Empleados(ListaEmpleados);

            identificador = Inputs.Input_String("Ingrese el identificador del empleado");

            try
            {

                empleado = ListaEmpleados.Find(x => x.Cedula == identificador);
               
                Console.WriteLine("Presione la tecla para asignar Incentivo");

                Console.ReadKey();
                Console.Clear();

                double incentivo_descuento = Inputs.Input_double("Ingrese descuento a aplicar: ");
                string descripcion = Inputs.Input_String("Ingrese el concepto: ");

                ListarEmpleado(empleado);


                listaEmpleados_AccionPersonal.Add(new Empleado_AccionPersonal { Cedula = empleado.Cedula, Incenctivo = incentivo_descuento, Concepto = descripcion });
                Console.WriteLine("Exito");


                Console.WriteLine($"Empleado {empleado.Nombres}, Incentivo {listaEmpleados_AccionPersonal.Last().Incenctivo}, Concepto: {listaEmpleados_AccionPersonal.Last().Concepto}");
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
                    SetIncentivo(ListaEmpleados);

                }

                Console.WriteLine("Saliendo...Presione la tecla para salir");

                Console.ReadKey();

                Console.Clear();



            }
        }

        public void SetDescuento(List<Empleados> ListaEmpleados)
        {

            Empleados empleado;

            string identificador = "";

            Listar.Listar_Empleados(ListaEmpleados);

            identificador = Inputs.Input_String("Ingrese el identificador del empleado");

            try
            {

                empleado = ListaEmpleados.Find(x => x.Cedula == identificador);

                Console.WriteLine("Presione la tecla para asignar Decuento");

                Console.ReadKey();
                Console.Clear();

                double descuento = Inputs.Input_double("Ingrese descuento a aplicar: ");
                string descripcion = Inputs.Input_String("Ingrese el concepto: ");

                ListarEmpleado(empleado);

                listaEmpleados_AccionPersonal.Add(new Empleado_AccionPersonal { Cedula = empleado.Cedula, Descuento = descuento, Concepto = descripcion });

                Console.WriteLine("Exito");


                Console.WriteLine($"Empleado {empleado.Nombres}, Descuento {listaEmpleados_AccionPersonal.Last().Descuento}, Concepto: {listaEmpleados_AccionPersonal.Last().Concepto}");
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
                    SetDescuento(ListaEmpleados);

                }

                Console.WriteLine("Saliendo...Presione cualquier tecla para salir");

                Console.ReadKey();

                Console.Clear();



            }
        }


        private void ListarEmpleado(Empleados empleado)
        {

            Console.WriteLine("**********EMPlEADO SELECCIONADO***********");

            Console.WriteLine("******************************************");
            Console.WriteLine("Cedula: " + empleado.Cedula);
            Console.WriteLine("Nombre: " + empleado.Nombres);
            Console.WriteLine("Cargo: " + empleado.Cargo);
            Console.WriteLine("Departamento: " + empleado.Departamento);
            Console.WriteLine("Salario Bruto: " + empleado.SalarioBruto);
            Console.WriteLine("******************************************");

        }


        public static List<Empleado_AccionPersonal> GetEmpleado_AccionPersonals()
        {
            return listaEmpleados_AccionPersonal;
        }

    }


}
    