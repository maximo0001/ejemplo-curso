using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    public class Persona
    {
        public int Edad {  get; set; }
        public float Sueldo { get; set; }  
        public string Nombre { get; }

        public Persona(string nombre) 
        { 
            this.Nombre = nombre;
        }
        public string Saludar()
        {
            return "hola soy " + Nombre;
        }
        public string Saludar(string nombre)
        {
            return "hola "+ nombre +"soy " + this.Nombre;

        }
    }
}
