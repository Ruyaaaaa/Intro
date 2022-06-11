using System;

namespace _6_condition_iforn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a, b, sonuc;

            Console.WriteLine("1.Sayıyı Giriniz");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Sayıyı Giriniz");
            b = Convert.ToInt32(Console.ReadLine());

            if ((a > 0 && a < 100) && (b > 0 && b < 100))
            {
                sonuc = a + b;
            }
            else
            {
                sonuc = -1;
            }
            Console.WriteLine($"Girilen sayıların toplamı {sonuc}");
            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();


        }
    }
}
