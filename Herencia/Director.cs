using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Director : Persona
    {
        public string Institucion;
        public double AnoDeJubilacion;

        public Director(string NombrePersona, byte edadPersona, string generoPersona, string institucion, double anoDeJubilacion) : base (NombrePersona, edadPersona, generoPersona)
        {
            Institucion = institucion;
            AnoDeJubilacion = anoDeJubilacion;
        }

        public override void Saludar()
        {
            base.Saludar();
        }
        public override void ImprimirInfo()
        {
            base.ImprimirInfo();
        }
        public void ImprimirInfoDirector()
        {
            Console.WriteLine("El director " + Nombre + " cuya institucion es " + Institucion + " se jubila en "+AnoDeJubilacion);
        }

    }
}
