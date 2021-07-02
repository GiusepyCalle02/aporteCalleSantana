using System;

namespace AporteCalleSantana3C
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concursante de la modalidad Logica Basica
            Console.WriteLine("Datos del primer estudiante");
            LogicaBasica persona1 = new LogicaBasica();
            persona1.mostrarDatos();
            persona1.nombre = "Giusepy Calle";
            persona1.modalidad = "Lógica Basica";
            persona1.laboratorio = 1; 
            Console.WriteLine("Hello World!");

            //Concursante de la modalidad Logica Avanzada
            Console.WriteLine("Datos del segundo estudiante");
            LogicaAvanzada persona2 = new LogicaAvanzada();
            persona2.mostrarDatos();
            persona2.nombre = "Reinaldo Rueda";
            persona2.modalidad = "Lógica Avanzada";
            persona2.laboratorio = 2;
            Console.WriteLine("Hello World!");

            //Concursante de la modalidad Empresarial
            Console.WriteLine("Datos del tercer estudiante");
            Empresarial persona3 = new Empresarial();
            persona3.mostrarDatos();
            persona3.nombre = "Maria Cazares";
            persona3.modalidad = "Lógica Empresarial";
            persona3.laboratorio = 3;
            Console.WriteLine("Hello World!");

            //Concursante de la modalidad Retos
            Console.WriteLine("Datos del cuarto estudiante");
            Retos persona4 = new Retos();
            persona4.mostrarDatos();
            persona4.nombre = "Gustavo Cedeño";
            persona4.modalidad = "Lógica Basica";
            persona4.laboratorio = 4;
            Console.WriteLine("Hello World!");
        }
    }
}
