using System;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = 0;

            if (a == b)
            {
                c = a + b;
                Console.WriteLine("o valor da soma que foi atribuido a C é: " + c);

            }
            else
            {
                c = a * b;
                Console.WriteLine("o valor da multiplicação que foi atribuido a C é: " + c);

            }
            Console.ReadKey();
        }
    }
}
