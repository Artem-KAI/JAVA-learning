using lvl3.Models;
using lvl3.Services;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        SplayTree tree = new SplayTree();

        // Ініціалізація (20 елементів)
        string[] names = { "Олег", "Андрій", "Вадим", "Галина", "Денис", "Євген", "Жанна", "Захар", "Ігор", "Кирило",
                           "Леонід", "Максим", "Назар", "Олена", "Павло", "Роман", "Степан", "Тарас", "Уляна", "Федір" };

        Console.WriteLine("=== ПРОЦЕС ФОРМУВАННЯ АМОРТИЗАЦІЙНОГО ДЕРЕВА ===");

        // Виправлений цикл перебору
        foreach (var name in names)
        {
            Console.WriteLine($"Додавання студента: {name}");
            // Створюємо студента та додаємо в дерево з амортизаційним балансуванням
            tree.Insert(new Student("Прізвище", name, "По-батькові", 100, true));

            // Після кожної вставки корінь дерева змінюється!
            Console.WriteLine($"  -> Поточний корінь дерева тепер: {tree.Root.Data.FirstName}");
        }

        Console.WriteLine("\n" + new string('=', 50));
        Console.WriteLine("Дерево ініціалізовано. Останній доданий елемент став коренем.");

        // Демонстрація пошуку
        Console.Write("\nВведіть ім'я для пошуку (напр. Андрій): ");
        string searchKey = Console.ReadLine();

        var result = tree.Search(searchKey);

        if (result != null)
        {
            Console.WriteLine($"\nЗНАЙДЕНО: {result.Data}");
            Console.WriteLine($"АМОРТИЗАЦІЯ: Тепер '{searchKey}' піднявся у корінь дерева!");
            Console.WriteLine($"Новий корінь: {tree.Root.Data.FirstName}");
        }
        else
        {
            Console.WriteLine("\nСтудента не знайдено.");
        }

        Console.ReadKey();
    }
}