using System;

namespace Operation_bit_to_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            //& Logical multiplication 
            int m1 = 5;
            int m2 = 14;
            Console.WriteLine(m1 & m2);
            
            // | Logical addition 
            int a1 = 2;
            int a2 = 5;
            Console.WriteLine(a1 | a2);
            
            // ^ Logical Exclisive XOR
            int x = 45; //number to encript
            int key = 102;// key
            int encript = x ^ key; //encripted result
            Console.WriteLine($"Encripted number: {encript}");

            int decript = encript ^ key; //decripted result
            Console.WriteLine($"Decripter number: {decript}");

            // ~ Logical negation or inversion
            int n = 13;                 
            Console.WriteLine(~n);

            int n1 = 13;
            int i =~n1;
            i += 1;
            Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
