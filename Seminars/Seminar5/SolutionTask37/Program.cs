//ищет произведение пар чисел в одномерном массиве. Парой считается первый и последний элемент, второй и предпоследний...

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
int[] CalculateTask(int[] inputArray)
{
    int[] resultArray = new int[inputArray.Length/2+1];
    int i = 0;
    while (i<resultArray.Length)
    {
        resultArray[i] = inputArray[i]*inputArray[inputArray.Length-1-i];
        i++;
    }
    return resultArray;
}

int[] bufferArray = FillingArray();
PrintArray(bufferArray);
int[] resultArray = CalculateTask(bufferArray);
PrintArray(resultArray);