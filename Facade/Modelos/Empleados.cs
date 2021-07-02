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
        public double SalarioBruto { get; set; }
        public double Incentivo { get; set; }
        public double Descuento { get; set; }
        public double Descuento_AFP { get; set; }
        public double Descuento_ASR { get; set; }
        public double SalarioNeto { get; set; }

        public Empleados()
        {
            Incentivo = 0;
            Descuento = 0;
            Descuento_ASR = 0;
            Descuento_AFP = 0;
            SalarioNeto = 0;
        }

    }
}
