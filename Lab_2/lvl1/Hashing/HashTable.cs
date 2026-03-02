namespace lvl1.Hashing;

using lvl1.Models;
using System;

internal class HashTable
{
    // описати хеш-таблицю з відкритою адресацією 
    // Чому це відкрита адресація:
    // використовується масив
    // всі елементи зберігаються прямо в масиві
    private Square[] table;
    private int size;

    public HashTable(int size)
    {
        this.size = size;
        this.table = new Square[size];
    }

    // використовує метод хешування - ділення k % size
    // key - периметр квадрата
    private int HashFunction(double key)
    {
        int k = (int)Math.Floor(key); // Math.Floor округлює число вниз, відкидає дробову частину     
        k = Math.Abs(k);// Abs бере модуль числа 
        return k % size;// Оператор % повертає остачу від ділення.
    }

    // вставити елементи так, щоб не було колізій
    public bool Insert(Square square)
    {
        int index = HashFunction(square.GetPerimeter());

        if (table[index] == null)
        {
            table[index] = square;
            return true;
        }

        return false; 
    }
     
    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n  Вміст хеш-таблиці  ");
        Console.WriteLine("{0,-5} | {1,-10} | {2}", "№", "Ключ(P)", "Елемент");
        Console.WriteLine(new string('-', 70));
        Console.ResetColor();

        for (int i = 0; i < size; i++)
        {
            if (table[i] != null)
            {
                Console.WriteLine("[{0:D3}] | {1,-10:F2} | {2}",
                    i, table[i].GetPerimeter(), table[i].ToString());
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[{0:D3}] | {1,-10} | Позиція вільна", i, "-");
                Console.ResetColor();
            }
        }
    }
}