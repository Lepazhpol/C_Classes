//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//*сортировка пузырьком

Console.Clear();
int[] bufferArray = FillingArray();
PrintArray(bufferArray);
Console.WriteLine("Количество четных элементов в массиве: " + CalculateTask(bufferArray));
Console.WriteLine("Отсортированный массив методом пузырька:");

PrintArray(BubleSort(bufferArray));
//к сожалению нет возможности править комментарий к отправленному ДЗ, я за ночь понял что не так. Простите))


//Метод возвращает массив заполненный случайными числами
int[] FillingArray()
{
    Console.WriteLine("Укажите размер массива: ");
    string imputLengthLine = Console.ReadLine() ?? "";
    int imputLength = int.Parse(imputLengthLine);
    int[] outArray = new int[imputLength];
    int i = 0;
    System.Random umberSintezator = new System.Random();
    while (i < imputLength)
    {
        outArray[i] = umberSintezator.Next(100, 1000);
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

//Метод производящий решение
int CalculateTask(int[] inputArray)
{
    int amount = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if ((inputArray[i] % 2) == 0) amount++;
    }
    return amount;
}

//Производит сортировку методом пузырька. Сейчас сделано в порядке возрастания. Чтобы было в порядке убывания(см внутрь)
int[] BubleSort(int[] inputArray)
{
    int buble = 0;
    for (int j = 0; j < inputArray.Length; j++)
    {
        for (int i = 0; i < inputArray.Length-1; i++)
        {
            if (inputArray[i] > inputArray[i+1])    //чтобы было в порядке убывания меняем больше на меньше
            {
                buble = inputArray[i];
                inputArray[i] = inputArray[i+1];
                inputArray[i+1] = buble;
            }
        }
    }
    return inputArray;
}