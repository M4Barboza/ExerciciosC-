using System;
using System.Globalization;

namespace Exercicio1Modulo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre a larura e altura do retângulo: ");
            r.Altura = double.Parse(Console.ReadLine());
            r.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Área = " + r.Area().ToString("F2", CultureInfo.InvariantCulture) );
            Console.WriteLine("Perimetro = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}