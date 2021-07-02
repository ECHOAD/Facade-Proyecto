using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Modelos;

namespace Facade.Helpers
{
    public static class Listar
    {

        public static void Listar_Empleados(List<Empleados> ListaEmpleados)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("Cedula: " + ListaEmpleados[i].Cedula);
                Console.WriteLine("Nombre: " + ListaEmpleados[i].Nombres);
                Console.WriteLine("Cargo: " + ListaEmpleados[i].Cargo);
                Console.WriteLine("Departamento: " + ListaEmpleados[i].Departamento);
                Console.WriteLine("Salario Bruto: " + ListaEmpleados[i].SalarioBruto);
                Console.WriteLine("******************************************");

            }

        }
    }
}
