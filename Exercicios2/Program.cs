using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int x = int.Parse(Console.ReadLine());

             if (x > 0)
             {
                 Console.WriteLine("NÃO NEGATIVO");
             }
             else
             {
                 Console.WriteLine("NEGATIVO");
             }*/

            //EXERCICIO 2:
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}