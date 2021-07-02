using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Modulos.Sub_Modulos.RRHH;
namespace Facade.Modulos
{
    public class Modulo_RRHH
    {
        public Modulo_RRHH()
        {
            ControlEmpleados= new Control_Empleados();
            PermisoEmpleado=new Permisos();  
            VacionesEmpleado = new Vacaciones();  
        }

        public  Control_Empleados ControlEmpleados { get; set; }
        public Permisos PermisoEmpleado{ get; set; }
        public Vacaciones VacionesEmpleado { get; set;  }
    }
}
