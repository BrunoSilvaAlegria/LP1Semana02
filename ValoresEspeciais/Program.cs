using System;

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
            
        }
    }
}
