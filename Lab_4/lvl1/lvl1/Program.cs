using lvl1.Services;
using lvl1.Models;
using System.Text;

namespace lvl1
{
    class Program
    {
        static void Main()
        { 
            Console.OutputEncoding = Encoding.UTF8;
             
            Student[] students = {
                new Student("Іваненко", "Олег", "KB-001", "IT-21"),
                new Student("Петренко", "Анна", "KB-005", "AC-11"),
                new Student("Сидоренко", "Ігор", "KB-003", "IT-21"),
                new Student("Коваль", "Марія", "KB-002", "BB-05"),
                new Student("Ткаченко", "Максим", "KB-004", "AC-11")
            };

            Console.WriteLine(">>> МАСИВ ДО СОРТУВАННЯ <<<");
            PrintTable(students);
             
            BubbleSorter.Sort(students);

            Console.WriteLine("\n>>> МАСИВ ПІСЛЯ СОРТУВАННЯ (БУЛЬБАШКА, ЗА ГРУПОЮ) <<<");
            PrintTable(students);

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }

        static void PrintTable(Student[] students)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"| {"Група",-8} | {"Квиток",-10} | {"Прізвище та ім'я",-22} |");
            Console.WriteLine(new string('-', 50));
            foreach (var s in students)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}