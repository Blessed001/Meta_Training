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
            //Continue
            for (int i = 0; i < n; i++)
            {
                if (i == 7)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("=====================================================");
            //Continue with While
            int j = 0;
            while (j < n)
            {
                if (j%2 == 0)
                {
                    j++;
                    continue;
                }
                Console.WriteLine(j);
                j++;
            }
            Console.ReadKey();
        }
    }
}
