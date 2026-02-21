namespace lvl3;

using lvl3.Models;
using lvl3.Hashing;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть розмір хеш-таблиці: ");
        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
        {
            Console.WriteLine("Некоректний розмір.");
            return;
        }

        var ht = new HashTable(size);
        var rnd = new Random();

        Console.Write("Скільки елементів вставити (з урахуванням колізій)? ");
        if (!int.TryParse(Console.ReadLine(), out int count) || count < 0)
        {
            Console.WriteLine("Некоректна кількість.");
            return;
        }

        // Вставка елементів (колізії дозволені, chaining)
        for (int i = 0; i < count; i++)
        {
            double x = rnd.NextDouble() * 100;
            double y = rnd.NextDouble() * 100;
            double side = 1 + rnd.NextDouble() * 10; // 1..11

            ht.Insert(new Square(x, y, side));
        }

        ht.Display("Вміст хеш-таблиці ДО видалення");

        // Критерій табл. 2.3 (варіант 5): S < S0
        Console.Write("\nВведіть поріг площі S0 (видалити всі квадрати з S < S0): ");
        if (!double.TryParse(Console.ReadLine(), out double s0) || s0 < 0)
        {
            Console.WriteLine("Некоректний поріг.");
            return;
        }

        int removed = ht.DeleteByAreaLessThan(s0);
        Console.WriteLine($"\nВидалено елементів: {removed}");

        ht.Display("Вміст хеш-таблиці ПІСЛЯ видалення");

        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}