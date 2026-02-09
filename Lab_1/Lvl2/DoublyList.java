package Lvl2;
//                       Варіант 5:
//         cтруктура даних: Двоспрямований список
//   тип елементів: Строковий (представляє цілі числа)
// 



// Опис структури даних зі зв’язним способом розміщення
class Node {
    String value; // Строковий тип, що представляє число
    Node next;
    Node prev;

    Node(String value) 
    {
        this.value = value;
        this.next = null;
        this.prev = null;
    }
}

public class DoublyList {
    private Node head;
    private Node tail;

    // Створення порожнього списку (конструктор)
    public DoublyList()
    {
        this.head = null;
        this.tail = null;
    }

    public void add(String value) 
    {
        Node newNode = new Node(value);
        if (head == null) {
            head = newNode;
            tail = newNode;
        } 
        else {
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }
    }

    // Видалення елемента за індексом
    public void removeByIndex(int index) 
    {
        if (head == null) {
            return;
        }

        Node current = head;
        for (int i = 0; current != null && i < index; i++) 
        {
            current = current.next;
        }

        if (current == null) { 
            return; // Індекс поза межами
        }

        if (current.prev != null) {
            current.prev.next = current.next;
        } 
        else {
            head = current.next; // Видаляємо голову
        }

        if (current.next != null) {
            current.next.prev = current.prev;
        } 
        else {
            tail = current.prev; // Видаляємо хвіст
        }
    }


    public void display() 
    {
        Node current = head;
        while (current != null) {
            System.out.print(current.value + " ");
            current = current.next;
        }
        System.out.println();
    }
}
