﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sb1 = sbyte.MinValue; //Valor mínimo deste tipo
            sbyte sb2 = sbyte.MaxValue; //Valor máximo deste tipo
            Console.WriteLine($"Tipo sbyte, vlr max: {sb2} e vlr min: {sb1}");

            short st1 = short.MinValue;
            short st2 = short.MaxValue;
            Console.WriteLine($"Tipo short, vlr max: {st2} e vlr min: {st1}");
            
            int i1 = int.MinValue;
            int i2 = int.MaxValue;
            Console.WriteLine($"Tipo int, vlr max: {i2} e vlr min: {i1}");

            long lg1 = long.MinValue;
            long lg2 = long.MaxValue;
            Console.WriteLine($"Tipo long, vlr max: {lg2} e vlr min: {lg1}");

            byte bt1 = byte.MinValue;
            byte bt2 = byte.MaxValue;
            Console.WriteLine($"Tipo byte, vlr max: {bt2} e vlr min: {bt1}");

            ushort us1 = ushort.MinValue;
            ushort us2 = ushort.MaxValue;
            Console.WriteLine($"Tipo ushort, vlr max: {us2} e vlr min: {us1}");

            uint ui1 = uint.MinValue;
            uint ui2 = uint.MaxValue;
            Console.WriteLine($"Tipo uint, vlr max: {ui2} e vlr min: {ui1}");
            
            ulong ul1 = ulong.MinValue;
            ulong ul2 = ulong.MaxValue;
            Console.WriteLine($"Tipo ulong, vlr max: {ul2} e vlr min: {ul1}");

            char cr1 = char.MinValue;
            char cr2 = char.MaxValue;
            Console.WriteLine($"Tipo char, vlr max: {cr2} e vlr min: {cr1}");

            float fl1 = float.MinValue;
            float fl2 = float.MaxValue;
            Console.WriteLine($"Tipo float, vlr max: {fl2} e vlr min: {fl1}");

            double db1 = double.MinValue;
            double db2 = double.MaxValue;
            Console.WriteLine($"Tipo double, vlr max: {db2} e vlr min: {db1}");

            decimal dc1 = decimal.MinValue;
            decimal dc2 = decimal.MaxValue;
            Console.WriteLine($"Tipo decimal, vlr max: {dc2} e vlr min: {dc1}");

            // Valores especiais

            // Valores NaN

            double x = double.PositiveInfinity/double.PositiveInfinity;
            double y = double.NegativeInfinity/double.NegativeInfinity;
            float z = float.NaN;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            // Valores infinitos

            x = double.PositiveInfinity;
            y = double.NegativeInfinity;
            z = float.PositiveInfinity;
            float a = float.NegativeInfinity;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);


            // Overflows em uints

            uint b = ushort.MaxValue;
            Console.WriteLine((ushort)(b + 1));

            b = ushort.MinValue;
            Console.WriteLine((ushort)(b - 1));

            // Overflows em floats e doubles

            float c = 3 * float.MinValue;
            Console.WriteLine(c);

            c = float.MaxValue + 1;
            Console.WriteLine(c);

            double d = 11 * double.MaxValue;
            Console.WriteLine(d);

            d = double.MaxValue + 1;
            Console.WriteLine(d);

            // Underflows em floats

            fl1 = fl2 = 123456789.0f;
            Console.WriteLine(fl1 == fl2 + 0.005005f);

        }
    }
}
