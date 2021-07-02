using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AporteCalleSantana3C
{
    public class Empresarial : Concursantes
    {
        public string LaboratorioEmpresarial { get; set; }
        public int cupos1 { get; set}
        {
            
         }

        public override void datos3()
        {
            Console.WriteLine("Laboratorio escogido: {1} Cupos: {2}",LaboratorioEmpresarial,cupos1 );
        }
    }
}
