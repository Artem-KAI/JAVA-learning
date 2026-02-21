namespace lvl2;

using lvl2.Hashing;
using lvl2.Models;
using System;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть розмір таблиці: ");
        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
        {
            Console.WriteLine("Некоректний розмір.");
            return;
        }

        var hashTable = new HashTable(size);
        var rand = new Random();

        Console.Write("Скільки елементів згенерувати? ");
        if (!int.TryParse(Console.ReadLine(), out int count) || count < 0)
        {
            Console.WriteLine("Некоректна кількість.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            // Випадкові координати та сторона (Random.NextDouble)
            double x = rand.NextDouble() * 100;
            double y = rand.NextDouble() * 100;
            double side = 1 + rand.NextDouble() * 10;

            var s = new Square(x, y, side);
            hashTable.Insert(s);
        }

        hashTable.Display();

        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}