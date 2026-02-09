package lvl3;
//                                         Варіант 5:
//                           Перша структура: Список (масивний/векторний)
//                               Друга структура: Список (зв’язний)
//  Завдання: Видалити зі першого списку парні числа та вставити їх у другий список за зростанням
//



public class Main {
    public static void main(String[] args) {
        // 1. Створюємо першу структуру (Масив/Векторна)
        int[] list1 = new int[10];
        int size1 = 0;

        // Вставляємо елементи
        int[] initialValues = {10, 7, 1, 5, 8, 4, 3, 12};
        for (int v : initialValues) list1[size1++] = v;

        System.out.println("Перший список (початковий):");
        printArray(list1, size1);

        // 2. Створюємо другу структуру (Двоспрямований список)
        DoublyLinkedList list2 = new DoublyLinkedList();

        // 3. Формуємо другу структуру: видаляємо парні з першої, додаємо в другу
        int i = 0;
        while (i < size1) {
            if (list1[i] % 2 == 0) {
                int evenNum = list1[i];
                
                // Додаємо в другий список із сортуванням
                list2.insertSorted(evenNum);
                
                // Видаляємо з першого списку (зсув)
                for (int j = i; j < size1 - 1; j++) {
                    list1[j] = list1[j + 1];
                }
                size1--;
                // Не збільшуємо i, бо на це місце став новий елемент
            } else {
                i++;
            }
        }

        // 4. Виводимо вміст обох структур
        System.out.println("\nПерший список після видалення парних:");
        printArray(list1, size1);

        System.out.println("Другий список (парні, відсортовані, строкові):");
        list2.display();
    }

    public static void printArray(int[] arr, int size) {
        if (size == 0) { System.out.println("порожній"); return; }
        for (int i = 0; i < size; i++) {
            System.out.print(arr[i] + " ");
        }
        System.out.println();
    }
}