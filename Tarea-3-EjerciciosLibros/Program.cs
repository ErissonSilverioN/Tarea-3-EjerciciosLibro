using System;

namespace Tarea_3_EjerciciosLibros
{
    class Program
    {
        static void Main(string[] args)
        {
            Capitulo9 capitulo = new Capitulo9();
            int op;
            Console.WriteLine("Menu \n" + "1.Ejercicio 9.1\n" + "2.Ejercicio 9.3\n" + "3.Ejercicio 9.4\n" + "Elija una opcion: ");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    capitulo.Ejercicio1();
                    break;
                case 2:
                    capitulo.Ejercicio3();
                    break;
                case 3:
                    capitulo.Ejercicio4();
                    break;

            }
        }
    }
}
