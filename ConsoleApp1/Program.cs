using System;
using System.Data;
using System.Globalization;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Рамис", new DateTime(2007, 6, 20));
            cat.MakeNoise();
            Console.WriteLine($"Коту по имени {cat.Name} уже {cat.GetAge()} лет");

            Cat cat2 = new Cat("Михалыч", new DateTime(2015, 6, 1));
            cat2.MakeNoise();
            Console.WriteLine($"Коту по имени {cat2.Name} уже {cat2.GetAge()} лет");

            CatSmartHouse catHouse = new CatSmartHouse(900);
            catHouse.AddCat(cat);
            catHouse.AddCat(cat2);

            Console.ReadLine();
        }

    }
}
