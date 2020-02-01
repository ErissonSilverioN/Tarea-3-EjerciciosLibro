using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_3_EjerciciosLibros
{
    public class Capitulo10
    {
      private int ID { get; set; }
      private string nombre { get; set; }
      private double precio { get; set; }
      private double costo { get; set; }
      private double cantidad { get; set; }



        public Capitulo10()
        {
            ID = 0;
            precio = 0;
            costo = 0;
            cantidad = 0;
        }



        public Capitulo10(int id, string nombre, double costo, double precio, double cantidad)
        {
            this.ID = id;
            this.nombre = nombre;
            this.costo = costo;
            this.precio = precio;
            this.cantidad = cantidad;
        }



    }

    class Estudiante
    {
        private int id { get; set; }
        private string nombre { get; set; }
        private string apellidos { get; set; }
        private string matricula { get; set; }
        private string cedula { get; set; }
        private string direccion { get; set; }
        private string carrera { get; set; }
        private string tetlefono { get; set; }

        public Estudiante()
        {
            id = 0;
        }
        public Estudiante(int id, string nombre, string apellidos, string matricula, string cedula, string direccion, string carrera, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.matricula = matricula;
            this.cedula = cedula;
            this.direccion = direccion;
            this.carrera = carrera;
            this.tetlefono = tetlefono;


        }

    }
    public class Poligono
    {
        private float lado;
        private float altura;
        private float base1;

        public Poligono(float lado)
        {
            this.lado = lado;
            altura = 0;
            base1 = 0;
        }

        public Poligono(float base1, float altura)
        {
            lado = 0;
            this.base1 = base1;
            this.altura = altura;

        }


        public float Lado
        {
            get
            {
                return lado;
            }
            set
            {
                if (value <= 0)
                    lado = 1;
                else
                    lado = value;
            }
        }
        public float Altura
        {
            get
            {
                return altura;
            }
            set
            {
                if (value <= 0)
                    altura = 1;
            }

        }
        private float Base1
        {
            get
            {
                return base1;
            }
            set
            {
                if (value <= 0)
                    base1 = 1;
            }
        }


    }
}
