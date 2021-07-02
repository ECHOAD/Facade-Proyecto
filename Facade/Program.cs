using System;
using System.Collections.Generic;
using System.Linq;
using Facade.Modelos;
using Facade.Helpers;
using Facade.Modulos.Sub_Modulos;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {

            Control_Empleados o= new Control_Empleados();

            List<Empleados> lst = new List<Empleados>{
            new Empleados { Cedula="1234",Nombres="Adrian",Departamento="Pega Blo",Cargo="Pica cemento",SalarioBruto=1563,Incentivo_o_Descuento=0,SalarioNeto=5000},
            new Empleados { Cedula="12334",Nombres="Adrian",Departamento="Pega Blo",Cargo="Pica cemento",SalarioBruto=1563,Incentivo_o_Descuento=0,SalarioNeto=5000},
            new Empleados { Cedula="12344",Nombres="Adrian",Departamento="Pega Blo",Cargo="Pica cemento",SalarioBruto=1563,Incentivo_o_Descuento=0,SalarioNeto=5000},
            new Empleados { Cedula="12345",Nombres="Adrian",Departamento="Pega Blo",Cargo="Pica cemento",SalarioBruto=1563,Incentivo_o_Descuento=0,SalarioNeto=5000},
            new Empleados { Cedula="12346",Nombres="Adrian",Departamento="Pega Blo",Cargo="Pica cemento",SalarioBruto=1563,Incentivo_o_Descuento=0,SalarioNeto=5000}
            };


            o.Desvincular(lst);


            Console.WriteLine(lst);


          
        }
    }
}
