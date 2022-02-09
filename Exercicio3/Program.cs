using System;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.Write("Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());


            imc = peso / Math.Pow(altura, altura);
            Console.WriteLine();

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc > 18.5 && imc <= 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }
            Console.ReadKey();
        }
    }
}
