using System;
using System.Collections.Generic;
using System.Linq;
using Facade.Modelos;
using Facade.Helpers;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Empleados> lst = new List<Empleados>{
            new Empleados { Cedula="1234",Nombres="Adrian",Departamento="Pega Blo",Cargo="Pica cemento",SalarioBruto=1563,Incentivo_o_Descuento=0,SalarioNeto=5000},
            new Empleados { Cedula="12334",Nombres="Adrian",Departamento="Pega Blo",Cargo="Pica cemento",SalarioBruto=1563,Incentivo_o_Descuento=0,SalarioNeto=5000},
            new Empleados { Cedula="12344",Nombres="Adrian",Departamento="Pega Blo",Cargo="Pica cemento",SalarioBruto=1563,Incentivo_o_Descuento=0,SalarioNeto=5000},
            new Empleados { Cedula="12345",Nombres="Adrian",Departamento="Pega Blo",Cargo="Pica cemento",SalarioBruto=1563,Incentivo_o_Descuento=0,SalarioNeto=5000},
            new Empleados { Cedula="12346",Nombres="Adrian",Departamento="Pega Blo",Cargo="Pica cemento",SalarioBruto=1563,Incentivo_o_Descuento=0,SalarioNeto=5000}
            };


            foreach (var item in lst)
            {

                Console.WriteLine("********************");
                Console.WriteLine(item.Cedula);
                Console.WriteLine(item.Nombres);
                Console.WriteLine(item.SalarioBruto);
                Console.WriteLine("********************");
            
            }

            Console.ReadKey();

            var algo = Inputs.Input_String("Digite la cedula: ");
            
            Empleados o= lst.Find(e => e.Cedula == algo);




            Console.WriteLine(o.Nombres);
        }
    }
}
