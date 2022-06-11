using System;

namespace _6_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1, sayi2;
            Console.WriteLine("Lütfen 1.sayıyı girin");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayıyı girin");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                Console.WriteLine($" En büyük sayı {sayi1}");
            }
            else if (sayi1< sayi2)
            {
                Console.WriteLine($" En büyük sayı {sayi2}");
            }
            else
            {
                Console.WriteLine("sayılar eşit");
            }

            Console.WriteLine("Kapatmak için tuşa basınız");
            Console.ReadKey();
        }
    }
}
