using System;
using Microsoft.VisualBasic;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
           // Input 
            Console.Write("Number Master, pick a int number between 0 & 100:");
            string str = Console.ReadLine();
            int n = int.Parse(str);

            if (n < 0 || n > 100)
            {
                Console.WriteLine("Error!!!\nExiting...");
            }
            else if (n > 0 && n < 100)
            {
                for (int a = 0; a <= 100; a++)
                {
                    Console.WriteLine("\n");
                }

                while (true)
                {
                    Console.Write("Player, pick a int number between 0 & 100:");
                    string str2 = Console.ReadLine();
                    int i = int.Parse(str2);

                    if (i < 0 || i > 100)
                    {
                        Console.WriteLine("Error!!!\n");

                    }
                    else if (i < n)
                    {
                        Console.WriteLine("Number Master's number is larger");
                    }
                    else if (i > n)
                    {
                        Console.WriteLine("Number Master's number is smaller");
                    }
                    else
                    {
                        Console.WriteLine("Success!!! You guessed the number!");
                    }
                }    
            }


        
        }
    }
}
