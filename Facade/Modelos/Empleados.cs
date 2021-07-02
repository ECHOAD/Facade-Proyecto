using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modelos
{
    public class Empleados : Persona
    {
        public override string Cedula { get; set; }
        public override string Nombres { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public double SalarioNeto { get; set; }
        public double Incentivo_o_Descuento { get; set; }
        public double SalarioBruto { get; set; }

        public Empleados()
        {
            Incentivo_o_Descuento = 0;
        }

    }
}
