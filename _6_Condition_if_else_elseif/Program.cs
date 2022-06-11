using System;

namespace _6_Condition_if_else_elseif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Lütfen bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if(sayi>0)
            {
                Console.WriteLine("Girilen sayi pozitif");
            }
            else if(sayi<0)
            { 
                Console.WriteLine("Girilen sayi negatif"); 
            }
            else
            {
                Console.WriteLine("Girilen sayi O");
            }

            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
            //elseif birbirine bağlı koşullar oluşturmak için
        }
    }
}
