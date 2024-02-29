using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {      
            // Question Input

            Console.WriteLine("What is your question?");
            Console.Write(">");
            string pergunta = Console.ReadLine();

            if (pergunta == "What are you?")
            {
                Console.Write("I'm a program made to answer your questions");
            }
       

        }
    }
}
