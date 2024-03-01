using System;

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

            if (n < 0 || n > 10)
            {
                Console.WriteLine("Error...\nExiting...");
            }
            

        
        }
    }
}
