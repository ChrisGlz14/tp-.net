using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Persona >> Lider >>  Developer >> Tester
            //Persona es mi clase BASE 

            Persona p1 = new Persona();
            
            Desarrollador d1 = new Desarrollador();
            //d1.legajo = "";

            Console.WriteLine(Lider.Saludar());
            
            //l1.nombre = "Chris";

            //Console.WriteLine(d1.legajo);

            //Tipos de clases
            //Abstracta

            //Persona p2 = new Persona();

            Console.ReadKey();
        }
    }
}
