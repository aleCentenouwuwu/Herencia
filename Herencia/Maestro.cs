using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Maestro : Persona
    {
        public string IdMaestro;
        public string CarreraEstudiada;
        public Maestro(string NombrePersona, byte edadPersona, string generoPersona, string IdMaestro, string CarreraEstudiada) : base(NombrePersona, edadPersona, generoPersona)
        {
            this.IdMaestro = IdMaestro;
            this.CarreraEstudiada = CarreraEstudiada;

        }

        public override void Saludar()
        {
            base.Saludar();
        }
        public override void ImprimirInfo()
        {
            base.ImprimirInfo();
        }
        public void ImprimirInfoMaestro()
        {
            Console.WriteLine("El maestro "+base.Nombre+" tiene ID: "+IdMaestro+" Titulo: "+CarreraEstudiada);
        }

    }
}
