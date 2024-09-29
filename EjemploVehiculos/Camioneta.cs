using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploVehiculos
{
    internal class Camioneta : Vehiculo
    {
        //La camioneta tiene una propiedad que no tendran los demas vehiculos (CargaMaxima)
        public float CargaMaxima {  get; set; }
        public string Traccion {  get; set; }
    }
}
