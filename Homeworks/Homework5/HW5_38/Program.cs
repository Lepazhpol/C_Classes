//Задайте массив чисел, найдите разницу между максимальным и миинимальным значением массива

Console.Clear();

int[] bufferArray = FillingArray();
PrintArray(bufferArray);
Console.WriteLine("Разница между наибольшим и наименьшим элементами массива: " + CalculateTask(bufferArray));


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
    int max = 0;
    int min = int.MaxValue; //кладет в переменную максимально возможное значение
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] > max) max = inputArray[i];
        if (inputArray[i] < min) min = inputArray[i];
    }
    return (max - min);
}