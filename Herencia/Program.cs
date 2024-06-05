using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante Frederick = new Estudiante("Frederick Rivera", 18,"Hombre ","Ingenieria en sistemas", 100);
            Frederick.Saludar();
            Console.ReadKey();

            Frederick.ImprimirInfo();
            Console.ReadKey();

            Frederick.VerificarAprobado();
            Console.ReadKey();

            Maestro Tatiana = new Maestro("Tatiana Valdivia", 35, "Mujer", "2134", "Ingenieria AgroIndustrial");
            Tatiana.Saludar();
            Console.ReadKey();
            Tatiana.ImprimirInfo();
            Console.ReadKey();
            Tatiana.ImprimirInfoMaestro();
            Console.ReadKey();

            Director Jose = new Director("Jose", 67, "Hombre", "UNI", 2024);
            Jose.Saludar();
            Console.ReadKey();
            Jose.ImprimirInfo();
            Console.ReadKey();
            Jose.ImprimirInfoDirector();
            Console.ReadKey();
        }
    }
}
