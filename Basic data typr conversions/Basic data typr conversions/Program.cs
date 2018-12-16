using System;

namespace Basic_data_typr_conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 4;
            byte b = (byte)(a + 70);

            ushort a1 = 4;
            byte b1 = (byte)a1;

            Console.WriteLine(b);
            Console.WriteLine(b1);
            Console.ReadKey();
        }
    }
}
