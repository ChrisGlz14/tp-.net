using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploVehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo();
            v1.Motor = "V8";

            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
            c1.Motor = "V6";
            c1.Traccion = "Traccion 4x4";

            Vehiculo v2 = new Camioneta();


            //La sentencia no funciona debido a que no sabemos si el vehiculo es una camioneta.
            //Camioneta c2 = new Vehiculo();

            c1.Color = "Rojo";
            c2.Color = "Azul";
            c3.Color = "Verde";

            List<Camioneta> listaCamioneta = new List<Camioneta>();
            listaCamioneta.Add(c1);
            listaCamioneta.Add(c2);
            listaCamioneta.Add(c3);
            

            //listaCamioneta[1].Color = "Negra";
            c2.Color = "Amarilla";


            //Recorrer una coleccion 

            foreach (Camioneta item in listaCamioneta)
            {
                Console.WriteLine("Color: " + item.Color);
            }





            Console.WriteLine(v1.Motor);
            Console.WriteLine(c1.Motor);
            Console.WriteLine(c1.Traccion);



            //Agregacion

            Auto a1 = new Auto();
            a1.Motor = new Motor();





            Console.WriteLine("La cantidad de camionetas es: " + listaCamioneta.Count);
            Console.WriteLine("El color de la segunda camioneta es " + listaCamioneta[1].Color );
            Console.WriteLine("El objeto eliminado es ");
            Console.ReadKey();
        }
    }
}
