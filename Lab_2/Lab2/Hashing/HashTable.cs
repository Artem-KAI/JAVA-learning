namespace lvl3.Hashing;

using lvl3.Models;

class HashTable
{
    private readonly LinkedList<Square>[] table;
    private readonly int size;

    public HashTable(int size)
    {
        this.size = size;
        table = new LinkedList<Square>[size];

        for (int i = 0; i < size; i++)
            table[i] = new LinkedList<Square>();
    }

    // Метод хешування: ділення
    private int HashFunction(double key)
    {
        int k = (int)Math.Floor(key);
        return Math.Abs(k) % size;
    }

    // Вставка з урахуванням колізій (chaining)
    public bool Insert(Square square)
    {
        int index = HashFunction(square.Perimeter);
        table[index].AddLast(square);
        return true;
    }

    // 3 рівень (табл. 2.3, варіант 5): видалити елементи з площею < S0
    public int DeleteByAreaLessThan(double s0)
    {
        int removed = 0;

        for (int i = 0; i < size; i++)
        {
            var node = table[i].First;
            while (node != null)
            {
                var next = node.Next;

                if (node.Value.Area < s0)
                {
                    table[i].Remove(node);
                    removed++;
                }

                node = next;
            }
        }

        return removed;
    }

    // Вивід: позиція, ключ, елементи (ланцюжок в одному рядку)
    public void Display(string title)
    {
        Console.WriteLine($"\n--- {title} ---");
        Console.WriteLine("{0,-5} | {1}", "Поз", "Ключ(P) -> Елементи");
        Console.WriteLine(new string('-', 120));

        for (int i = 0; i < size; i++)
        {
            Console.Write("[{0:000}] | ", i);

            if (table[i].Count == 0)
            {
                Console.WriteLine("Позиція вільна");
                continue;
            }

            foreach (var sq in table[i])
            {
                Console.Write($"P={sq.Perimeter:F2} => {sq}   ||   ");
            }

            Console.WriteLine();
        }

        Console.WriteLine(new string('-', 120));
    }
}