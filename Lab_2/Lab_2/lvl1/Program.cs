using System;
using LabHash.Hashing;
using LabHash.Models;

class Program
{
    static void Main()
    {
        Console.Write("Введіть розмір хеш-таблиці: ");
        int size = int.Parse(Console.ReadLine()!);

        HashTable table = new HashTable(size);

        Console.Write("Введіть кількість елементів: ");
        int n = int.Parse(Console.ReadLine()!);

        int added = 0;

        while (added < n)
        {
            Square sq = new Square();

            if (table.Insert(sq))
            {
                Console.WriteLine($"Додано: P={sq.P:F2}");
                added++;
            }
            else
            {
                Console.WriteLine($"Колізія! P={sq.P:F2}");
            }
        }

        table.Print();
    }
}