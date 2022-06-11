using System;

namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int vize, final, ortalama;

            Console.WriteLine("vize değerini giriniz");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("final değerini giriniz");
            final = Convert.ToInt32(Console.ReadLine());

            if ((vize > 0 && vize < 100) && (final > 0 & final < 100))
            {
                ortalama = (((vize * 40) / 100) + ((final * 60) / 100));


                if (ortalama > 0 && ortalama < 25)
                {
                    Console.WriteLine($" {ortalama}-FF");
                }

                if (ortalama > 26 && ortalama < 40)
                {
                    Console.WriteLine($" {ortalama}-DC");
                }

                if (ortalama > 41 && ortalama < 60)
                {
                    Console.WriteLine($" {ortalama}-CC");

                }
                if (ortalama > 61 && ortalama < 80)
                {
                    Console.WriteLine($" {ortalama}-BB");
                }
                if (ortalama > 81 && ortalama < 100)
                {
                    Console.WriteLine($" {ortalama}-AA");
                }
            }
            Console.WriteLine("Kapatmak için tuşa basınız");
            Console.ReadKey();


        }
    }
}
