using System;
using LabHash.Models;

namespace LabHash.Hashing;

public class HashTable
{
    private Square[] table;
    private int size;

    public HashTable(int size)
    {
        this.size = size;
        table = new Square[size];
    }

    // спец≥альний метод: ключ + позиц≥€
    private int Hash(Square sq)
    {
        int key = (int)sq.P;
        return key % size;
    }

    public bool Insert(Square sq)
    {
        int index = Hash(sq);

        if (table[index] != null)
            return false; // кол≥з≥€ Ч елемент не додаЇтьс€

        table[index] = sq;
        return true;
    }

    public void Print()
    {
        Console.WriteLine("\n’еш-таблиц€:");
        Console.WriteLine("------------------------------------------------------------");

        for (int i = 0; i < size; i++)
        {
            if (table[i] == null)
            {
                Console.WriteLine($"[{i,2}] : EMPTY");
            }
            else
            {
                Console.WriteLine(
                    $"[{i,2}] : Key={table[i].P,8:F2} | {table[i]}"
                );
            }
        }

        Console.WriteLine("------------------------------------------------------------");
    }
}