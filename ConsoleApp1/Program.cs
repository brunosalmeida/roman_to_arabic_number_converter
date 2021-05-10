using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a roman number to convert:");
            var roman = Console.ReadLine();

            var translate = new Translate();
            var arabic = translate.TranslateToArabic(roman);

            Console.WriteLine(arabic);
        }

        
    }
}
