using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Modelos;

namespace Facade.Modulos.Sub_Modulos.Nomina
{

    public class Pago
    {
        protected const double Desc_AFP = 0.0287;
        protected  const double Desc_ARS = 0.0301;
        private List<Empleado_AccionPersonal> Descuentos_o_Incentivos = AccionPersonal.GetEmpleado_AccionPersonals();
        private ExportarNominaExcelEmpleados Exporta_NominaEmpleados_Excel = new();

        public void RealizarPago(List<Empleados> Lista_Empleados)
        {

            if (Lista_Empleados.Count != 0)
            {

                if (AccionPersonal.GetEmpleado_AccionPersonals().Count > 0)
                {
                    for (int i = 0; i < AccionPersonal.GetEmpleado_AccionPersonals().Count; i++)
                    {
                        var Empleado = Lista_Empleados.Find(x => x.Cedula == Descuentos_o_Incentivos[i].Cedula);
                        Empleado.Incentivo += Descuentos_o_Incentivos[i].Incenctivo;
                        Empleado.Descuento += Descuentos_o_Incentivos[i].Descuento;



                    }

                }

                foreach (var item in Lista_Empleados)
                {
                    item.Descuento_AFP = item.SalarioBruto * Desc_AFP;
                    item.Descuento_ASR = item.SalarioBruto * Desc_ARS;
                    item.SalarioNeto = (item.SalarioBruto - (item.Descuento_AFP + item.Descuento_ASR +item.Descuento)+(item.Incentivo));

                }

                Exporta_NominaEmpleados_Excel.ExportaDatos(Lista_Empleados);



            }


        }

    }
}
