using System;

namespace _6_Condition_ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1, sayi2;
            Console.WriteLine("Lütfen 1. Sayiyi Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Sayiyi Giriniz");
            sayi2 =Convert.ToInt32(Console.ReadLine());

            int enbuyukSayi;

            if (sayi1>sayi2)
            {
                enbuyukSayi = sayi1;
            }
            else //if kosulunun olmaması durumunda calısır
            {
                enbuyukSayi = sayi2;
            }
            Console.WriteLine($"Girilen en büyük sayi {enbuyukSayi}");
            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();

        }
    }
}
