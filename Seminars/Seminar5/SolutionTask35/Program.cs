//Задается одномерный массив из 123 случайных чисел. Находит количество элементов массива, значения которых лежат в отрезке [10,99]

//Метод возвращает массив заполненный случайными числами
int[] FillingArray()
{
    int[] outArray = new int[123];
    int i = 0;
    System.Random umberSintezator = new System.Random();
    while (i < 123)
    {
        outArray[i] = umberSintezator.Next();
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

//Метод ищущий элемент в массиве (ЛОГИЧЕСКИЙ)
int CalculateTask(int[] inputArray, int downBorder, int upBorder)
{
    int resultCount = 0;
    int i = 0;
    while (i < inputArray.Length)
    {
        if (inputArray[i] >= downBorder && inputArray[i] <= upBorder)
        {
            Console.Write(inputArray[i]);
            resultCount++;
        }
        i++;
    }
    return resultCount;
}

int[] bufferArray = FillingArray();
PrintArray(bufferArray);
Console.WriteLine(CalculateTask(bufferArray, 10, 9));