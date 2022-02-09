using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, soma;

            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            c = Convert.ToDouble(Console.ReadLine());

            soma = a + b;

            if (soma < c)
            {
                Console.WriteLine("A soma de A + B é menor que C");
            }
            else
            {
                Console.WriteLine("A soma de A + B não é menor que C");
            }
            Console.ReadKey();    
        }
    }
}
