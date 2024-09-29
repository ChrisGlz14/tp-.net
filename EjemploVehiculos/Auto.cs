using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploVehiculos
{
    internal class Auto : Vehiculo
    {

        public Auto()
        {
            Chasis = new Chasis();
        }

        public string Modelo { get; set; }
        public string Color { get; set; }


        //Agregacion
        public Motor Motor { get; set; } //Motor es un objeto de tipo Motor como propiedad del vehiculo.


        //Composición  
        public Chasis Chasis { get; } //El chasis siempre sera el mismo.
    }
}
