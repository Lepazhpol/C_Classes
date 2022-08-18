// Переворачивает одномерный массив (последний элемент будет на первом месте, а первый - на последнем)

int[] testArray = FillingArray(13);
PrintArray(testArray);
int[] reversedArray = ReverseNewArray(testArray);
PrintArray(reversedArray);
PrintArray(ReverseSwapArray(testArray));






//Метод возвращает массив заполненный случайными числами
int[] FillingArray(int arrayLength)
{
    int[] outArray = new int[arrayLength];
    int i = 0;
    System.Random umberSintezator = new System.Random();
    while (i < 13)
    {
        outArray[i] = umberSintezator.Next(-1000, 1000);
        i++;
    }
    return outArray;
}

//Метод печатающий масиив
void PrintArray(int[] inputArray)
{
    int i = 0;
    while (i < inputArray.Length - 1)
    {
        Console.Write(inputArray[i] + ", ");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}

//Метод переворачивающий массив созданием нового массива
int[] ReverseNewArray(int[] inputArray)
{
    int length = inputArray.Length;
    int[] newArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        newArray[length - 1 - i] = inputArray[i];
    }
    return newArray;
}

//Метод переворачивающий массив без создания новго массива
int[] ReverseSwapArray(int[] inputArray)
{
    int length = inputArray.Length;
    int buf;
    for (int i = 0; i < length / 2; i++)
    {
        buf = inputArray[i];
        inputArray[i] = inputArray[length - 1 - i];
        inputArray[length - 1 - i] = buf;
    }
    return inputArray;
}
