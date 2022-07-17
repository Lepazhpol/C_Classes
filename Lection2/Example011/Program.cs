// использование войд-методов для наполнения массива случайными числами и вывода их на экран
// затем регаем предыдущую задачу, где нужно вывести индекс известного нам элемента массива (обозначено в комментариях "(2)")

void FillArray(int[] collection)       //метод, который наполняет массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 20);
        index++;
    }
}

void PrintArray(int[] col)      // метод, который выводит значения массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)     //(2) объявляем функцию, которая ищет индекс
{
    int count = collection.Length;
    int index = 0;
    int position = -1;      // -1 мы используем как условное обозначение на случай, если в массиве не будет ни одного искомого элемента

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }

    return position;

}


int[] array = new int[10];  // создать новый массив с именем array в котором будет 10 элементов. При создании все элементы равны 0

FillArray(array);   // вводим в методы необходимый массив array
PrintArray(array);

Console.WriteLine(); //пустая строка для отделения
int pos = IndexOf(array, 4); // смотри в функцию IndexOf. Мы засовываем в функцию на место массива collection массив array, а на место find встает 4. То есть мы ищем значение 4 в массиве array
Console.WriteLine(pos);