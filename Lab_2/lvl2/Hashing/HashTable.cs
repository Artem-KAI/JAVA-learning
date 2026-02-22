namespace lvl2.Hashing;

using lvl2.Models;
using System;
using System.Collections.Generic;

class HashTable
{
    private LinkedList<Square>[] table;
    private int size;

    public HashTable(int size)
    {
        this.size = size;
        table = new LinkedList<Square>[size];

        for (int i = 0; i < size; i++)
            table[i] = new LinkedList<Square>();
    }
     
    private int HashFunction(double key)
    {
        int k = (int)Math.Floor(key);
        return Math.Abs(k) % size;
    }

    public bool Insert(Square square)
    {
        int index = HashFunction(square.GetPerimeter());
        table[index].AddLast(square);
        return true;
    } 

    public void Display()
    {
        Console.WriteLine("\n--- Вміст хеш-таблиці (Роздільне зв’язування) ---");
        Console.WriteLine("{0,-5} | {1}", "Поз", "Ключ(P) -> Елемент");
        Console.WriteLine(new string('-', 110));

        for (int i = 0; i < size; i++)
        {
            Console.Write("[{0:D3}] | ", i);

            if (table[i].Count == 0)
            {
                Console.WriteLine("Позиція вільна");
                continue;
            }

            foreach (var item in table[i])
            { 
                Console.Write($"P={item.GetPerimeter():F2} => {item}  ||  ");
            }

            Console.WriteLine();
        }

        Console.WriteLine(new string('-', 110));
    }
}