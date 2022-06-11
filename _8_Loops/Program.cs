using System;

namespace _8_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<3; i++)
            {
                Console.WriteLine("Hello World!");
            }

            int a = 0;
            while(a<3)
            {
                Console.WriteLine("Hello World!");
                a++;
            }

            int b = 0;
            do
            {
                Console.WriteLine("Hello Do While");
                b++;
            }
            while (b < 3);

            Console.WriteLine("Kapatmak için bir tuşa bas");
            Console.ReadKey();

        }
    }
}
