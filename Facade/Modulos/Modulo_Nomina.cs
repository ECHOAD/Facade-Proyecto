using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Modelos;
using Facade.Modulos.Sub_Modulos.Nomina;


namespace Facade.Modulos
{
    public class Modulo_Nomina
    {
        public AccionPersonal AccionPersonal { get; set; } 
        public Pago Pago { get; set; } 

        public Modulo_Nomina()
        {
            Pago = new Pago();
            AccionPersonal = new AccionPersonal(); 
        }
    }
}
