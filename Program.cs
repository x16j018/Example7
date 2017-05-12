using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte valueSByte = -100;
            byte valueByte = 100;
            short valudShort = -20000;
            ushort vaueUShort = 50000;
            int valueInt = -1000000000;
            uint valueUInt = 4000000000;
            long valueLong = -80000000000000;
            ulong valueULong = 90000000000000000;

            float valueFloat = 3.1415F;
            double valueDouble = 3.1415926535;

            char valueChar = 'A';
            string valueString = "C# PROGRAM";

            bool valueBool = true;

            Console.WriteLine("sbyte : {0}", valueSByte);
            Console.WriteLine("byte: {0}", valueByte);
            Console.WriteLine("short: {0}", valudShort);
            Console.WriteLine("ushort: {0}", vaueUShort);
            Console.WriteLine("int: {0}", valueInt);
            Console.WriteLine("uint: {0}", valueUInt);
            Console.WriteLine("long: {0}", valueLong);
            Console.WriteLine("ulong: {0}", valueULong);
            Console.WriteLine("float: {0}", valueFloat);
            Console.WriteLine("double: {0}", valueDouble);
            Console.WriteLine("char: {0}", valueChar);
            Console.WriteLine("string: {0}", valueString);
            Console.WriteLine("bool: {0}", valueBool);
        }
    }
}
