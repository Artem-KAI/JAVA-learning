package lvl3;
//                                         Варіант 5:
//                           Перша структура: Список (масивний/векторний)
//                               Друга структура: Список (зв’язний)
//  Завдання: Видалити зі першого списку парні числа та вставити їх у другий список за зростанням
//



class Node {
    String value; 
    Node next, prev;

    Node(String value) {
        this.value = value;
    }
}

// Клас для другого списку (Двоспрямований, зв'язний)
class DoublyLinkedList {
    Node head;

    // Метод для вставки з сортуванням за зростанням (завдання 3 рівня)
    public void insertSorted(int num) {
        String valStr = String.valueOf(num);
        Node newNode = new Node(valStr);

        if (head == null) {
            head = newNode;
            return;
        }

        Node current = head;
        // Шукаємо позицію для вставки (порівнюємо як числа)
        while (current != null && Integer.parseInt(current.value) < num) {
            if (current.next == null) break;
            current = current.next;
        }

        if (Integer.parseInt(current.value) >= num) {
            // Вставка перед current
            newNode.next = current;
            newNode.prev = current.prev;
            if (current.prev != null) current.prev.next = newNode;
            else head = newNode;
            current.prev = newNode;
        } else {
            // Вставка в самий кінець
            current.next = newNode;
            newNode.prev = current;
        }
    }

    public void display() {
        Node current = head;
        if (current == null) { System.out.println("порожній"); return; }
        while (current != null) {
            System.out.print(current.value + " ");
            current = current.next;
        }
        System.out.println();
    }
}