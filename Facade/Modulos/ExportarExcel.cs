using System;

using SpreadsheetLight;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Facade.Modelos;

namespace Facade.Modulos
{
    public class ExportarNominaExcelEmpleados :IExportarDatosEmpleados
    {
        public void ExportaDatos(List<Empleados> Lista_Empleado)
        {
            string direccionArchivo = AppDomain.CurrentDomain.BaseDirectory + "Persistencia.xlsx";


            SLDocument osLDocument;


            System.Data.DataTable dt = new();
            dt.Columns.Add("Cedula", typeof(string));
            dt.Columns.Add("Nombres", typeof(string));
            dt.Columns.Add("Cargo", typeof(string));
            dt.Columns.Add("Departamento", typeof(string));
            dt.Columns.Add("Salario", typeof(string));
            dt.Columns.Add("Otros Ingresos", typeof(string));
            dt.Columns.Add("AFP", typeof(string));
            dt.Columns.Add("ARS", typeof(string));
            dt.Columns.Add("Otros Descuentos", typeof(string));
            dt.Columns.Add("Sueldo Neto", typeof(string));




            if (File.Exists(direccionArchivo))
            {


                osLDocument = new(direccionArchivo);

                int iRow = 2;



                while (!string.IsNullOrEmpty(osLDocument.GetCellValueAsString(iRow, 1)))
                {
                    string Cedula = osLDocument.GetCellValueAsString(iRow, 1);
                    string Nombres = osLDocument.GetCellValueAsString(iRow, 2);
                    string Cargo = osLDocument.GetCellValueAsString(iRow, 3);
                    string Departamento = osLDocument.GetCellValueAsString(iRow, 4);
                    string Salario = osLDocument.GetCellValueAsString(iRow, 5);
                    string Otros_Ingresos = osLDocument.GetCellValueAsString(iRow, 6);
                    string AFP = osLDocument.GetCellValueAsString(iRow, 7);
                    string ARS = osLDocument.GetCellValueAsString(iRow, 8);
                    string Otros_Descuentos = osLDocument.GetCellValueAsString(iRow, 9);
                    string Sueldo_Neto = osLDocument.GetCellValueAsString(iRow, 10);


                    dt.Rows.Add(Cedula, Nombres,Cargo, Departamento, Salario, Otros_Ingresos, AFP, ARS,Otros_Descuentos,Sueldo_Neto);

                    iRow++;

                }


            }

            foreach (var Datos in Lista_Empleado)
            {
                dt.Rows.Add(Datos.Cedula, Datos.Nombres, Datos.Cargo, Datos.Departamento, Datos.SalarioBruto, Datos.Incentivo, Datos.Descuento_AFP, Datos.Descuento_ASR, Datos.Descuento,Datos.SalarioNeto);

            }


            osLDocument = new();


            osLDocument.ImportDataTable(1, 1, dt, true);

            osLDocument.SaveAs(direccionArchivo);

        }
    }
}
