using System;
using System.Globalization;

namespace Problema_sem_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre com as medidas do triângulo X:");

            xA= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo y:");

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p* (p-xA) *(p-xB) * (p-xC));
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            double v = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(v * (v - yA) * (v - yB) * (v - yC));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) Console.WriteLine("Maior Área: X");
            else Console.WriteLine("Maior Área: Y");*/

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            double areaY = y.Area();
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) Console.WriteLine("Maior Área: X");
            else Console.WriteLine("Maior Área: Y");
        }
    }
}