package lvl1;
//                Варіант 5:
//         cтруктура даних: список
//       тип елементів: цілі числа
//   розміщення в пам’яті: векторне (масив)
//



public class List {
    private int[] data;
    private int size;

    // Конструктор (створення екземпляра структури)
    public List(int capacity) 
    {
        this.data = new int[capacity];
        this.size = 0;
    }

 
    public void add(int value) 
    {
        if (size < data.length) {
            data[size++] = value;
        } 
        else {
            System.out.println("Error: List is full");
        }
    }

    // Метод для видалення за індексом зі зсувом елементів
    public void remove(int index) 
    {
        if (index < 0 || index >= size) {
            System.out.println("Error: incorrect index");
            return;
        }
        
        for (int i = index; i < size - 1; i++) {
            data[i] = data[i + 1];
        }

        size--;
    }

    // Метод для виведення вмісту
    public void display() 
    {
        if (size == 0) {
            System.out.println("List is empty");
            return;
        }

        for (int i = 0; i < size; i++) {
            System.out.print(data[i] + " ");
        }
        
        System.out.println();
    }
}