using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    internal class Botella
    {
        public string color { get; }
        public string material { get; }
        public int capacidad { get; }
        private int cantidadActual { get; set; }

        public Botella(string color, string material)
        {
            capacidad = 100;
            cantidadActual = 0;
            this.material = material;
            this.color = color;
        }

        public float Recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = (100 - cantidadActual);
                cantidadActual += dif;
                return (dif * 50 / 100);
            }
            cantidadActual = 100;
            return 50;
        }
        public float Recargar(int cantidad) 
        { 
            cantidadActual += cantidad;
           
            return (cantidad * 50/100);
        }
    }
}
