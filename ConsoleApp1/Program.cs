using System;
using System.Globalization;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Рамис", new DateTime(2007, 6, 20));
            Console.WriteLine($"Коту по имени {cat.Name} уже {cat.GetAge()} лет");

            cat.HungryStatus = 150;

            Console.ReadLine();
        }
    }
}
