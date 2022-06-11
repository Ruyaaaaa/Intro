using System;

namespace _7_SwitchCaseOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = 'A';
            Console.WriteLine("Lütfen bir harf giriniz");
            char harf = Convert.ToChar(Console.ReadLine());

            switch (char.ToUpper(harf))
            {
                case 'A':
                case 'E':
                case 'I':
                case 'İ':
                case 'O':
                case 'Ö':
                case 'U':
                case 'Ü':
                    Console.WriteLine("Sesli");
                    break;
                default:
                    Console.WriteLine("Sessiz");
                    break;
            }
            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();

        }
    }
}
