using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables Initialized
            string pergunta, resposta;

            // Question Input
            Console.Write("What is your question? > ");
            pergunta = Console.ReadLine();

            // Question Recognizer and Proper Answer
            switch (pergunta)
            {
                case "What are you?":
                    resposta= "I'm a program made for answering your questions";
                    break; 
                default:
                    resposta = "Sorry, I don't know the answer for that";
                    break;                   
            }

            // Print Response
            Console.WriteLine(resposta);
        }
    }
}
