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
            Console.WriteLine($"Коту по имени {cat.Name} уже {cat.GetAge()} лет");

            cat.HungryStatus = 150;
            cat.HungryStatusChanged += Cat_HungryStatusChanged;

            Cat cat2 = new Cat("Михалыч", new DateTime(2015, 6, 1));
            Console.WriteLine($"Коту по имени {cat2.Name} уже {cat2.GetAge()} лет");
            cat2.HungryStatusChanged += Cat2_HungryStatusChanged;
            // Я где-то часа два пытался понять, почему-то она криво работает, а вот почему.
            // Так должно быть или нет?
            Console.ReadLine();
        }

        private static void Cat2_HungryStatusChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Cat cat = (Cat)sender;
            if (cat.HungryStatus < 20 && rnd.Next(0, 10) < 5)
                cat.Feed();
            else
                cat.GetStatus();
            // throw new NotImplementedException();
        }

        private static void Cat_HungryStatusChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Cat cat = (Cat)sender;
            if (cat.HungryStatus < 20 && rnd.Next(0, 10) < 5)
                cat.Feed();
            else
                cat.GetStatus();
            // throw new NotImplementedException();
        }
    }
}
