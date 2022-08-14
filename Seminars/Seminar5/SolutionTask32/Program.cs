//Инвертировать значения элементов массива


//Метод возвращает массив заполненный случайными числами из промежутка от до
int[] FillingArray()
{
    int[] outArray = new int[12];
    int i = 0;
    System.Random umberSintezator = new System.Random();
    while (i < 12)
    {
        outArray[i] = umberSintezator.Next(-9, 10);
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

//Метод инвертирует элементы массива
int[] ColculateTask(int[] inputArray)
{
    int[] outputArray = new int[12];
    int i = 0;
    while (i < 12)
    {
        outputArray[i] = inputArray[i] * (-1);
        i++;
    }
    return outputArray;
}

//Метод инвертирует элементы массива тильда
int[] InventArrayTilda(int[] inputArray)
{
    int i = 0;
    while (i < inputArray.Length)
    {
        inputArray[i] = (~inputArray[i]) + 1; //~ оператор инверсии. ~переменная + 1 - иневертирует число
        i++;
    }
    return inputArray;
}


int[] bufferArray = FillingArray();
PrintArray(bufferArray);
int[] resultArray = ColculateTask(bufferArray);
PrintArray(resultArray);
resultArray = InventArrayTilda(bufferArray);
PrintArray(resultArray);