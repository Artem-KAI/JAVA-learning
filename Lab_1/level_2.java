//                       Варіант 5:
//         cтруктура даних: Двоспрямований список
//   тип елементів: Строковий (представляє цілі числа)
// 



public class level_2 {

    // Описати структуру даних зі зв’язним способом     2.1
    static class Node {
        int value;
        Node next;
        Node prev;

        Node(int value) {
            this.value = value;
            this.next = null;
            this.prev = null;
        }
    }

    public static void main(String[] args) {

        // створення екземпляра структури даних         2.2
        Node head = null;
        Node tail = null;

        // Вставити елементи в структуру                2.3
        int[] values = {10, 7, 1, 5, 8};

        for (int v : values) {
            Node newNode = new Node(v);

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

        System.out.println("Contents of the list:");
        printList(head);

        // Видалити декілька елементів і вивести вміст  2.4
        head = removeByIndex(head, 1);
        head = removeByIndex(head, 1);

        System.out.println("Після видалення елементів:");
        printList(head);
    }

    static void printList(Node head) {
        Node current = head;
        while (current != null) {
            System.out.print(current.value + " ");
            current = current.next;
        }
        System.out.println();
    }

    static Node removeByIndex(Node head, int index) {
        if (head == null) return null;

        Node current = head;
        int i = 0;

        while (current != null && i < index) 
        {
            current = current.next;
            i++;
        }

        if (current == null) {
            return head;
        }

        if (current.prev != null) {
            current.prev.next = current.next;
        } 
        else {
            head = current.next;
        }

        if (current.next != null) {
            current.next.prev = current.prev;
        }

        return head;
    }
}

