using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {





            //AnimalDomestico a1 = new AnimalDomestico();
            //a1.Nombre = "Roco";
            //a1.comunicarse();

            Gato g1 = new Gato();
            g1.Nombre = "Gato claudio";

            Animal a1 = g1;

            Gato g3 = (Gato)a1;
            g3.Nombre = "Pantera";


            Console.WriteLine(g1.Nombre);
            Console.WriteLine(g3.Nombre);


            //Lista
            List<Animal> animales = new List<Animal>();
            animales.Add(a1);
            animales.Add(g1);
            animales.Add(new Pez());
            animales.Add(new Tigre());
            animales.Add(new Aguila());
            animales.Add(new Perro());
            animales.Add(new Canario());

            foreach (Animal item in animales)
            {
                Console.WriteLine("Este animal se comunica : " + item.comunicarse());
            }


            //Lista segmentada por Interfaz

            List<Flyable> listaVoladores = new List<Flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());
            listaVoladores.Add(new Perro());



            //Casteo Explicito



            Console.WriteLine(a1.comunicarse());
            Console.WriteLine(g1.comunicarse());

            Console.ReadKey();
        }
    }
}
