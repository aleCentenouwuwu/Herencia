using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Estudiante : Persona
    {
        private string carrera;
        private double nota;
        public Estudiante(string NombrePersona, byte edadPersona, string generoPersona, string CarreraEstudiante, double NotaEstudiante) : base (NombrePersona, edadPersona, generoPersona)
        {
            carrera = CarreraEstudiante;
            nota = NotaEstudiante;
        }

        public override void Saludar()
        {
            base.Saludar();
        }
        public override void ImprimirInfo()
        {
            base.ImprimirInfo();
        }
        public void VerificarAprobado()
        {
            if (nota < 60)
            {
                Console.WriteLine("El estudiante "+base.Nombre+" de la carrera "+carrera+ " esta reprobado.");
            }
            else
            {
                Console.WriteLine("El estudiante " + base.Nombre + " de la carrera " + carrera + " esta aprobado, con la nota de "+nota);
            }
        }
    }
}
