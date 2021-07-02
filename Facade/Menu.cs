using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Modelos;
using Facade.Helpers;
using Facade.Modulos;


namespace Facade
{
    public static class Menu
    {
        private static List<Empleados> lst_Empleados=new List<Empleados>();

        private static Modulo_RRHH ModuloRRHH = new Modulo_RRHH();

        private static Modulo_Nomina ModuloNomina = new Modulo_Nomina();

    


        public static void IncializarMenu()
        {
            

            int seleccion = 0;
            Console.WriteLine("**********Sistema RRHH***********");

            Console.WriteLine("¿En que apartado desea trabajar ?");

            Console.WriteLine("1-RRHH  2-Nominas de Pago 3-Salir del programa");

            seleccion = Inputs.Input_int("Seleccion");

            Console.Clear();


            switch (seleccion)
            {
                case 1:
                    Console.WriteLine("Esta en el apartado de RRHH");

                    Console.WriteLine("¿Que funcion quiere realizar?");

                    Console.WriteLine("1-Contratar  2-Desvincular 3-Regresar");

                    seleccion = Inputs.Input_int("Seleccion: ");

                    if (seleccion <= 0 || seleccion > 3)
                    {
                        Console.WriteLine("Seleccion no existe");
                        Console.ReadKey();
                        Console.Clear();
                        goto case 1;
                    }


                    if (seleccion == 1)
                    {
                        ModuloRRHH.ControlEmpleados.Contratar(lst_Empleados);
                        goto case 1;

                    }
                    else if (seleccion == 2)
                    {
                        ModuloRRHH.ControlEmpleados.Desvincular(lst_Empleados);
                        goto case 1;
                    }
                    else if (seleccion == 3)
                    {
                        IncializarMenu();
                    }


                    break;
                case 2:
                    Console.WriteLine("Esta en el apartado de Nomina");

                    Console.WriteLine("¿Que funcion quiere realizar?");

                    Console.WriteLine("1-Pagar 2- Regresar");

                    seleccion = Inputs.Input_int("Seleccion: ");

                    if (seleccion <= 0 || seleccion > 2)
                    {
                        Console.WriteLine("Seleccion no existe");
                        Console.ReadKey();
                        Console.Clear();
                        goto case 2;
                    }

                    if (seleccion == 1)
                    {
                        ModuloNomina.Pago.RealizarPago(lst_Empleados);
                        goto case 2;
                    }
                    else
                    {
                        Console.Clear();
                        IncializarMenu();
                    }
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Presione cualquier tecla para salir...");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Seleccion no existe");
                    Console.ReadKey();
                    Console.Clear();
                    IncializarMenu();
                    break;
            }


        }


    }
}


