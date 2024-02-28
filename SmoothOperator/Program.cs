using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Insira um número ineiro não-negativo ->\t");
            string str = Console.ReadLine();

            byte n = byte.Parse(str);

            Console.WriteLine(n--);
            Console.WriteLine(n++);
            
        }
    }
}
