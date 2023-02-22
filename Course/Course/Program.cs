using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /* bool completo = false;
             char genero = 'F';
             char letra = '\u0041';
             sbyte n1 = 127;
             int n2 = 1000;
             int n3 = 2147483647;
             long n4 = 2147483648L;
             float n5 = 4.5f;
             double n6 = 4.5;
             string nome = "Matheus";

             Console.WriteLine(completo);
             Console.WriteLine(genero);
             Console.WriteLine(letra);
             Console.WriteLine(n1);
             Console.WriteLine(n2);
             Console.WriteLine(n3);
             Console.WriteLine(n4);
             Console.WriteLine(n5);
             Console.WriteLine(n6);  
             Console.WriteLine(nome);*/


            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preco é $ {preco2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondao (três casas decimais): {medida:F3}");

            //string frase = Console.ReadLine();

            //Console.WriteLine(frase);
        }
    }
}