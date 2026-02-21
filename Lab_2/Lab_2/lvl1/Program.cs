using lvl1.Hashing;
using lvl1.Models;

// Колізії можуть виникати під час генерації, але для першого рівня
// вони не розв’язуються, елемент не додається,
// і генерація продовжується, доки таблиця не буде заповнена без колізій.

class Program
{

    static void Main(string[] args)
    {
        Console.Write("Введiть розмiр хеш-таблицi: ");
        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
        {
            Console.WriteLine("Некоректний розмiр.");
            return;
        }

        HashTable hashTable = new HashTable(size);
        Random random = new Random();

        Console.Write("Скiльки елементiв вставити (без колiзiй)? ");
        int countToInsert = int.Parse(Console.ReadLine());

        if (countToInsert > size)
        {
            Console.WriteLine("Помилка: неможливо вставити елементiв більше, нiж розмiр таблицi.");
            return;
        }

        int inserted = 0;
        int attempts = 0;

        // Генерація та вставка елементів, поки не заповнимо потрібну кількість без колізій
        while (inserted < countToInsert && attempts < 2000)
        {
            double x = random.NextDouble() * 100;
            double y = random.NextDouble() * 100;
            double side = 1 + random.NextDouble() * 20;

            Square newSquare = new Square(x, y, side);

            if (hashTable.Insert(newSquare))
            {
                inserted++;
            }
            attempts++;
        }

        hashTable.Display();
        Console.WriteLine($"\nУспiшно вставлено: {inserted} елементiв (спроб: {attempts}).");

        Console.WriteLine("\nНатиснiть будь-яку клавiшу для виходу...");
        Console.ReadKey();
    }
}