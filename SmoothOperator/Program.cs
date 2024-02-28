using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Insira um número inteiro não-negativo -> ");
            string str = Console.ReadLine();

            byte n = byte.Parse(str);

            Console.WriteLine(--n);
            Console.WriteLine(++n);
            Console.WriteLine(n/2);
            Console.WriteLine(n<<3);
            
            
        }
    }
}
