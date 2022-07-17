// использование войд-методов для наполнения массива случайными числами и вывода их на экран

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


int[] array = new int[10];  // создать новый массив с именем array в котором будет 10 элементов. При создании все элементы равны 0

FillArray(array);   // вводим в методы необходимый массив array
PrintArray(array);
