using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AporteCalleSantana3C
{
    public abstract class Concursantes
    {
        public string nombre { get; set; }
        public string modalidad { get; set; }
        public int laboratorio {get; set;}
        public int ordenador { get; set; }
        public string software { get; set; }
        public string softwarealumno { get; set; }


        public virtual void mostrarDatos()
        {
            Console.WriteLine("Nombre: {0} Modalidad del concurso: {1} Laboratorio escogido: {2} Computadora: {3} Software del Laboratorio: {4} Software requerido por el estudiante: {5}", nombre, modalidad, laboratorio, ordenador, software, softwarealumno);
        }

        public abstract void datos1();
        public abstract void datos2();
        public abstract void datos3();
        public abstract void datos4();



        public abstract void seleccionarComputadora();


    }
}
