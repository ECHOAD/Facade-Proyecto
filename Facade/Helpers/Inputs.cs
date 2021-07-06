using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Helpers
{
    public static class Inputs
    {

        public static string Input_String(string details)
        {
            string read="";
            try
            {
                Console.Write($"\n{details}");

                read = Console.ReadLine();
                Console.Clear();

            }
            catch (Exception)
            {

                Console.WriteLine("Verifique lo que digitio , trate de nuevo...Presione cualquier tecla para avanzar");
                Console.ReadKey();
                Console.Clear();
                Input_String(details);
            }
          



            return read;
        }

       


        public static double Input_double(string details)
        {
            string read = "";
            try
            {
                Console.Write($"\n{details}");

                read = Console.ReadLine();
                Console.Clear();
                return double.Parse(read);

            }
            catch (Exception)
            {

                Console.WriteLine("Verifique lo que digitio , trate de nuevo...Presione cualquier tecla para avanzar");
                Console.ReadKey();
                Console.Clear();
                Input_double(details);
            }

            return 0;
        }

        public static int Input_int(string details)
        {
            string read = "";
            try
            {
                Console.Write($"\n{details}");

                read = Console.ReadLine();
                Console.Clear();
                return int.Parse(read);
            }
            catch (Exception)
            {

                Console.WriteLine("Verifique lo que digitio , trate de nuevo...Presione cualquier tecla para avanzar");
                Console.ReadKey();
                Console.Clear();
                Input_int(details);
            }
        ;

            return 0;
        }



    }
}
