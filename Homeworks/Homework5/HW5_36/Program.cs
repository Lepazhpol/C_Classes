﻿//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
//* находит пары в массиве и выводит их

Console.Clear();
int[] bufferArray = FillingArray();
PrintArray(bufferArray);
Console.WriteLine("Сцмма эелементов стоящих на четной позиции: " + CalculateTask(bufferArray));
PairPrint(bufferArray);




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
    int sum = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if ((i % 2) == 0)
        {
            sum = sum + inputArray[i];
        }
    }
    return sum;
}

//Метод печатающий пары чиел ы массиве
int[] PairPrint(int[] inputArray)
{
    //int[] resultArray = new int[inputArray.Length/2+1];
    int i = 0;
    while (i<inputArray.Length/2)
    {
        Console.WriteLine(inputArray[i] + " " +inputArray[inputArray.Length-1-i]);
        i++;
    }
    return inputArray;
}
