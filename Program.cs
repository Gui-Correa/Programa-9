using System;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine("Valor de a= " + a);
            Console.WriteLine("Valor de b= " + b);

            Console.ReadKey();

        }
    }
}
