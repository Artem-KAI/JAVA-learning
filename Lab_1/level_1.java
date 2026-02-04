//                Варіант 5:
//         cтруктура даних: список
//       тип елементів: цілі числа
//   розміщення в пам’яті: векторне (масив)
//



public class level_1 {

    public static void main(String[] args) {

        // Створили екземпляр структури даних              1.1
        int[] mylist = new int[10];
        int size = 0;  

        // Вставити елементи в структуру даних             1.2
        mylist[size++] = 3;
        mylist[size++] = 7;
        mylist[size++] = 12;
        mylist[size++] = 5;
        mylist[size++] = 9;

        System.out.println("Contents of the list:");
        for (int i = 0; i < size; i++) {
            System.out.print(mylist[i] + " ");
        }
        System.out.println();

        // Видалити декілька елементів зі структури даних  1.3
        for (int i = 1; i < size - 1; i++) {
            mylist[i] = mylist[i + 1];
        }
        size--;

        for (int i = 2; i < size - 1; i++) {
            mylist[i] = mylist[i + 1];
        }
        size--;


        System.out.println("After the elements appear:");
        for (int i = 0; i < size; i++) {
            System.out.print(mylist[i] + " ");
        }
    }
}


