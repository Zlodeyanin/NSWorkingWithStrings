using System;

namespace NSWorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, zodiacSign, workplace;
            int age;
            Console.Write("Ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ваш знак зодиака: ");
            zodiacSign = Console.ReadLine();
            Console.Write("Ваше место работы: ");
            workplace = Console.ReadLine();
            Console.WriteLine($"Ваше имя - {name}, ваш возраст - {age}, ваш знак зодиака - {zodiacSign}, ваше место работы - {workplace}");
            Console.ReadKey();
        }
    }
}