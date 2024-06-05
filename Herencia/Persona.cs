using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Persona
    {
       public string Nombre;
       public byte edad;
       public string genero;
            
        public Persona(string NombrePersona, byte edadPersona, string generoPersona)
        {
            Nombre = NombrePersona;
            edad = edadPersona;
            genero = generoPersona;
        }
        public virtual void Saludar()
        {
            Console.WriteLine("Hola! Me llamo "+Nombre);
        }
        public virtual void ImprimirInfo()
        {
            Console.WriteLine("Nombre: "+Nombre+"\nEdad: "+edad+"\nGenero: "+genero);
        }
    }
}
