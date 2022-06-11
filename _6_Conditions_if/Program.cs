
using System;

namespace _6_Conditions_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Merhaba bir deger giriniz");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 10)
            {
                Console.WriteLine("Girilen deger 10 sabitinden büyüktür...");
            }
            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();


        }
    }
}
