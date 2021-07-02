using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AporteCalleSantana3C
{
    public class LogicaAvanzada : Concursantes
    {
        public string LaboratorioAvanzado { get; set}
        public int cupos { get; set }

        public override void datos2()
        {
            Console.WriteLine("Laboratorio escogido: {0} cupo: {1}", LaboratorioAvanzado, cupos);
        }
    }
}
