using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tarea_3_EjerciciosLibros
{
    public class Capitulo9
    {

        public struct Tienda
        {
            public string NomProducto;

        }

        public void Ejercicio1()
        {
            int producto = 0;

            ArrayList tienda = new ArrayList();
            Tienda t = new Tienda();
            Console.WriteLine("Digite la cantida de producto a guardar");
            producto = Convert.ToInt32(Console.ReadLine());
            do
            {
                for (int i = 0; i < producto; i++)
                {
                    Console.WriteLine("Ingrese lo producto a guardar");
                    t.NomProducto = Console.ReadLine();
                    tienda.Add(t);


                }

                foreach (Tienda p in tienda)
                {
                    Console.WriteLine("Producto guardado es: {0}", p.NomProducto);


                }
                Console.WriteLine("Si decea segir preciones 1 si no 0");
                producto = Convert.ToInt32(Console.ReadLine());
            } while (producto != 0);
            Console.ReadKey();
        }
        public struct dueno
        {
            public string Nombre;
            public int edad;
            public int telefono;
            public mascota mas;
        }

        public struct mascota
        {
            public string Nom;
            public string Mascota;
            public int edad;

        }



        public void Ejercicio3()
        {
            dueno due = new dueno();

            Console.WriteLine("Nombre del Dueno");
            due.Nombre = Console.ReadLine();
            Console.WriteLine("Edad");
            due.edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Telefono");
            due.telefono = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite lo datos de la macosta");
            Console.WriteLine("Nombre");
            due.mas.Nom = Console.ReadLine();
            Console.WriteLine("Tipo de mascota");
            due.mas.Mascota = Console.ReadLine();
            Console.WriteLine("Edad ce la mascota");
            due.mas.edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El Nombre del dueno es: {0}\n La edad: {1}\n El telefono es {2} \n Nombre de la Macosta {3}\n El tipo de macosta es: {4} " +
                "La Edad de la Macosta es: {5}", due.Nombre, due.edad, due.telefono, due.mas.Nom, due.mas.Mascota, due.mas.Mascota);

            Console.ReadKey();
        }
        enum Neumaticos { Tubuless = 1, Deinvierno, Runflat };
        public void Ejercicio4()    
        {
            int op;
            Neumaticos neu;
            Console.WriteLine("Neumaticos Del 1 a 3");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    neu = Neumaticos.Tubuless;
                    Console.WriteLine("{0}", neu);
                    break;
                case 2:
                    neu = Neumaticos.Deinvierno;
                    Console.WriteLine("{0}", neu);
                    break;
                case 3:
                    neu = Neumaticos.Runflat;
                    Console.WriteLine("{0}", neu);
                    break;
            }


        }


    }
}
