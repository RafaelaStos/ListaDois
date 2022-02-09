using System;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valor1, valor2, valor3;

            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            valor3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //1,2,3
            if (valor1 > valor2 && valor2 > valor3)
            {
                Console.WriteLine(valor1 + "\n" + valor2 + "\n" + valor3);
            }//2,3,1
            else if (valor2 > valor3 && valor3 > valor1)
            {
                Console.WriteLine(valor2 + "\n" + valor3 + "\n" + valor1);
            }//3,1,2
             else if (valor3 > valor1 && valor1 > valor2)
            {
                Console.WriteLine(valor3 + "\n" + valor1 + "\n" + valor2);
            }//1,3,2

           else if (valor1 > valor2 && valor1 > valor3 && valor3> valor2)
              {
                  Console.WriteLine(valor1 + "\n" + valor3 + "\n" + valor2);
              }//2,1,3
              else if (valor2 > valor1 && valor2 > valor3 && valor3 > valor1)
              {
                  Console.WriteLine(valor2 + "\n" + valor3 + "\n" + valor1);
              }//3,2,1

             else if( valor3 > valor2 && valor2 < valor1 )
             {
                 Console.WriteLine(valor3 + "\n" + valor2 + "\n" + valor1);
             }
     
            Console.ReadKey();
        }
    }
}
