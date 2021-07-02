using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AporteCalleSantana3C
{
    public class Retos : Concursantes
    {

        public string retos {get;set;}
        public int cupos { get; set; }

        public override void datos4()
        {
            Console.WriteLine("Laboratorio escogido: {1} Cupos: {2} ",retos, cupos);
        }
    }
}
