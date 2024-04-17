using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Carlos Menem");
            persona.Edad = 18;
            persona.Sueldo = 500000;
            Console.WriteLine(persona.Saludar());
            Console.ReadKey(); 
        }
    }
}
