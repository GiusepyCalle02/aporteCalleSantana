using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AporteCalleSantana3C
{
    public class LogicaBasica:Concursantes
    {
        public string LaboratorioBasico;
        public int cupos;

        public override void datos1()
        {
            Console.WriteLine("Laboratorio escogido: {0} cupo: {1}",LaboratorioBasico, cupos);
        }

        public override void seleccionarComputadora()
        {
            if(ordenador==1)
            {
                Console.WriteLine("Laboratorio asignado: {0} Cupos del laboratorio: {1}  Computadora: {2} Software de laboratorio: {3} Sotfware de estudiante: {4}",LaboratorioBasico, cupos, ordenador, software,y ti)
            }
        }
    }    

    
}
