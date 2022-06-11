using System;

namespace _8_Loops_Ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string k1 = "İ", k2 = "i";
            bool karsilastir = k1 == k2; //false
            char c = 'E';
            while (c== 'E')
            {
                Console.WriteLine("Lütfen Sayı Giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Tekrar sayı girmek ister misiniz? E/H");
                c = Convert.ToChar(Console.ReadLine());

            }

            Console.ReadKey();
        }
    }
}
