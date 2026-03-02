class Program()
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string[] storage = new string[10];

        // Хеш-функція: бере довжину слова і повертає індекс
        int GetHash(string key)
        {
            return key.Length % 10;
        }

        // Додаємо посилку "Box"
        string item = "Box";
        int index = GetHash(item); // 3 % 10 = 3
        storage[index] = item;

        Console.WriteLine($"Посилка {item} лежить на полиці №{index}");
    }
}