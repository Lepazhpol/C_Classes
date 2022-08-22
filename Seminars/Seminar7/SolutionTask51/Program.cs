// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной даигонали ( с индексами (0,0) (1,1))

int[,] array = FillingTwoDimArray(10,10);
PrintTwoDimArray(array);
Console.WriteLine("Сумма элементов на главной диагонали: " + CalculateDiagonalOfArray(array));


//Метод возвращает двумерный массив заполненный случайными числами
int[,] FillingTwoDimArray(int countRow, int countColumn)
{

    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    System.Random numberSintezator = new System.Random();
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSintezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}

//Метод печатающий двумерный масиив
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}


int CalculateDiagonalOfArray(int[,] inputArray)
{
    int outSumDiaganal = 0;
    int i = 0;
    Console.ForegroundColor = ConsoleColor.Yellow;
    while (i < inputArray.GetLength(0))
    {
        outSumDiaganal += inputArray[i,i];
        i++;
    }
    return outSumDiaganal;
}
