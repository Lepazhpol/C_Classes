/*=======================================================================
 Задайте две матрицы. Напишите программу, 
 которая будет находить произведение двух матриц.
 ========================================================================*/

Console.WriteLine("Первый массив");
int[,] array1 = FillArrayBivariate(AskUser("Введите число строк массива 1: "), AskUser("Введите число столбцов массива 1: "));
PrintTwoDimensionalArray(array1);
Console.WriteLine();

Console.WriteLine("Второй массив");
int[,] array2 = FillArrayBivariate(AskUser("Введите число строк массива 2: "), AskUser("Введите число столбцов массива 2: "));
PrintTwoDimensionalArray(array2);
Console.WriteLine();

Console.WriteLine("Произведение массивов");
MultiplicationArray(array1, array2);


//метод опроса пользователя
int AskUser(string ask)
{
    Console.WriteLine(ask);
    int answer = int.Parse(Console.ReadLine() ?? "");
    return answer;
}

// метод заполнения двумерного массива 
int[,] FillArrayBivariate(int countRow, int countCalumn)
{
    int[,] outArray = new int[countRow, countCalumn];
    System.Random numberSintezator = new System.Random();
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCalumn; j++)
        {
            outArray[i, j] = numberSintezator.Next(0, 50);

        }
    }
    return outArray;
}

// метод печати двумерного массива
void PrintTwoDimensionalArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Метод прямого перемножения массивов 
void MultiplicationArray(int[,] array_1, int[,] array_2)
{
    int[,] outArray = new int[array_1.GetLength(0), array_1.GetLength(1)];
    // проверка, что массивы совпадают
    if (array_1.GetLength(0) == array_2.GetLength(0) && array_1.GetLength(1) == array_2.GetLength(1))
    {
        for (int i = 0; i < outArray.GetLength(0); i++)
        {
            for (int j = 0; j < outArray.GetLength(1); j++)
            {
                outArray[i, j] = array_1[i, j] * array_2[i, j];
            }
        }
        PrintTwoDimensionalArray(outArray);
    }
    else Console.WriteLine("Произведение массивов неодинаковой размерности найти нельзя");  //вернее можно, но это уже совсем другая история
}

