using System;
using Microsoft.VisualBasic;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
           // Input 
            Console.Write("Number Master, pick a number between 0 and 100: > ");
            string str = Console.ReadLine();
            int n = int.Parse(str);

            if (n < 0 || n > 100)
            {
                Console.WriteLine("Error...\nExiting...");
            }
            else if (n > 0 && n < 100)
            {
                for (int a = 0; a <= 100; a++)
                {
                    Console.WriteLine("\n");
                }
                Console.Write("Player, pick a number between 0 and 100: > ");
                
            }


        
        }
    }
}
