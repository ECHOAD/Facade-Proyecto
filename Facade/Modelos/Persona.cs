using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modelos
{
    public abstract class Persona
    {
        public abstract string Cedula { get; set; }
        public abstract string Nombres { get; set; }
    }
}
