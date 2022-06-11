using System;

namespace _5_App5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1, sayi2;

            Console.WriteLine("Lütfen 1. Sayıyı Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Sayıyı Giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi1 / sayi2;

            Console.WriteLine($"İki Sayının bolumunun sonucu= {sonuc}");

            Console.WriteLine($"{sayi1} sayısı ile {sayi2} sayısının bolumu = {sonuc}");

            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}
