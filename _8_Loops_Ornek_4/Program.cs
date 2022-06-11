using System;

namespace _8_Loops_Ornek_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //n adet öğrencinin (öğrenci sayısı istenecek) vize final notları istenecek
            //ortalama hesaplanacak, ekrana yazdırılacak

            Console.WriteLine("Kaç adet öğrenci için hesaplama yapılacak");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Öğrenci vize");
                float vize = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Öğrenci final");
                float final = Convert.ToSingle(Console.ReadLine());

                float ortalama = vize * 0.4f + final * 0.6f;
                Console.WriteLine($"Öğrencinin ortalaması= {ortalama}");
            }   
        }
    }
}
