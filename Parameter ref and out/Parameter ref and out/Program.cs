using System;

namespace Parameter_ref_and_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int[] seq = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            int youYear;
            GetAge(1991, 2018, out youYear);
            Sum(ref a);


            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            Params(seq);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"Your age is {youYear} years");
            Console.ReadKey();
        }

        //Using a parameter out
        static void GetAge(int birdayYear, int yearNow, out int yourAge)
        {
            yourAge = yearNow - birdayYear;
        }

        //Using a parameter ref
        static void Sum(ref int x)
        {
            x++;
            int result = x;
            Console.WriteLine($"The sum is {result}");
        }
        //Using params
        static void Params(params int[] num)
        {
            for(int i =0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }


    }
}
