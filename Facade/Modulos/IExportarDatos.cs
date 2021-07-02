using Facade.Modelos;
using System.Collections.Generic;

namespace Facade.Modulos
{
    public interface IExportarDatosEmpleados
    {

        public void ExportaDatos(List<Empleados> Lista_Empleado);
    }
}