using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número Inteiro\n");
            int num = int.Parse(Console.ReadLine());


            int a = 0, b = 1;

            bool pertence = false;

            Console.WriteLine("Sequência de Fibonacci\n");
            Console.WriteLine("{0} {1}", a, b);
            while (b <= num)
            {
                int c = a + b;
                Console.WriteLine(" {0}", c);
                if (c == num) pertence = true;
                a = b;
                b = c;
            }


            if (pertence)
            {
                Console.WriteLine("\nO número {0} pertence a sequência de Fibonacci", num);

            }
            else
            {
                Console.WriteLine("\nO número {0} não pertence à sequência de Fibonaci", num);
            }
            Console.ReadLine();

        }
    }
}
