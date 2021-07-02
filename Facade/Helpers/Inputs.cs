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
            Console.Write($"\n{details}");

            string read= Console.ReadLine();
            Console.Clear();


            return read;
        }

       


        public static double Input_double(string details)
        {
            Console.Write($"\n{details}");

            string read = Console.ReadLine();
            Console.Clear();


            return double.Parse(read);
        }

        public static int Input_int(string details)
        {
            Console.Write($"\n{details}");

            string read = Console.ReadLine();

            Console.Clear();
        
            return int.Parse(read);
        }



    }
}
