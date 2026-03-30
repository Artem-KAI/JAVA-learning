using System;
using System.Text;
using lvl3.Models;
using lvl3.Services;

namespace lvl3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Student[] students = {
                new Student("Коваль", "Іван", "КН-21"),
                new Student("Бондар", "Олег", "АП-12"),
                new Student("Шевченко", "Марина", "БЦ-05"),
                new Student("Ткач", "Анна", "КН-21"),
                new Student("Лис", "Яна", "АП-12")
            };

            Console.WriteLine(">>> ПЕРЕД ШВИДКИМ СОРТУВАННЯМ <<<");
            Print(students);

            QuickSorter.Sort(students, 0, students.Length - 1);

            Console.WriteLine("\n>>> ПІСЛЯ QUICKSORT (МЕДІАНА З ТРЬОХ) <<<");
            Print(students);

            Console.ReadKey();
        }

        static void Print(Student[] students)
        {
            Console.WriteLine(new string('-', 40));
            foreach (var s in students) Console.WriteLine(s);
            Console.WriteLine(new string('-', 40));
        }
    }
}