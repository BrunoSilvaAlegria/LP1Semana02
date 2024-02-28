using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a altura(a) e o raio(r) do cilndro, por esta ordem:");

            Console.Write("a: ");
            string str1 = Console.ReadLine();
            
            Console.Write("r: ");
            string str2 = Console.ReadLine();

            float a = float.Parse(str1);
            float r = float.Parse(str2);

            float volume = MathF.PI * MathF.Pow(r,2) * a;

            float x = Convert.ToSingle(Math.PI);

            float area = 2 * x * r * (r + a);

            Console.WriteLine($"O volume do cilindro é {volume} e a sua área é {area}");


        }
    }
}
