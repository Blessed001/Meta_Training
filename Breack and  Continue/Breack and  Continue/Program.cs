using System;

namespace Breack_and__Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            // Breaking clicle
            for(int  i = 0; i < n; i++)
            {
                if (i == 7)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("=====================================================");
            //Continue cicle
            for (int i = 0; i < n; i++)
            {
                if (i == 7)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
