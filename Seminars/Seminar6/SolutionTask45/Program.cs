// Создает копию заданного одномерного массива с помощью поэлементного копирования

// int[] testArray = FillingArray();
// PrintArray(testArray);

// // int[] outArray = Copy


//метод копирующий массив любого типа
object[] CopyArrayStandartTool(params object[] inputArray)
{
    object[] bufferArray = new object[inputArray.Length];
    inputArray.CopyTo(bufferArray,0);       //CopyTo(куда копируем, с какого индекса)
    return bufferArray;
}

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