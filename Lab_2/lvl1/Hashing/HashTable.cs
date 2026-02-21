namespace lvl1.Hashing;

using lvl1.Models;
using System;

internal class HashTable
{
    private Square[] table;
    private int size;

    public HashTable(int size)
    {
        this.size = size;
        this.table = new Square[size];
    }

    // Метод хешування: Ділення (Table 2.1, Col 3)
    // Ключ: Периметр (Table 2.1, Col 4)
    private int HashFunction(double key)
    {
        int k = (int)Math.Floor(key);
        k = Math.Abs(k);
        return k % size;
        // Беремо цілу частину периметра для залишку від ділення
        //return (int)Math.Floor(key) % size;
    }

    // Метод вставки (Перший рівень: повертає false, якщо позиція зайнята)
    public bool Insert(Square square)
    {
        int index = HashFunction(square.GetPerimeter());

        if (table[index] == null)
        {
            table[index] = square;
            return true;
        }

        return false; // колізія
    }

    // Виведення вмісту хеш-таблиці
    public void Display()
    {
        Console.WriteLine("\n--- Вміст хеш-таблиці ---");
        Console.WriteLine("{0,-5} | {1,-10} | {2}", "№", "Ключ(P)", "Елемент");
        Console.WriteLine(new string('-', 70));

        for (int i = 0; i < size; i++)
        {
            if (table[i] != null)
            {
                Console.WriteLine("[{0:D3}] | {1,-10:F2} | {2}",
                    i, table[i].GetPerimeter(), table[i].ToString());
            }
            else
            {
                Console.WriteLine("[{0:D3}] | {1,-10} | Позиція вільна", i, "-");
            }
        }
    }
}