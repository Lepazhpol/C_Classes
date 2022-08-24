//// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//// значение этого элемента или же указание, что такого элемента нет.
//// Заполнить числами Фиббоначи и выделить цветом найденную цифру

Console.Clear();

// потому что не хотим плодить кучу методов...
Console.WriteLine("Зададим размер массива. Введите число строк: ");
int countRow = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите число столбцов: ");
int countCalumn = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите строку искомого элемента: ");
int LookingForRow = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите столбец искомого элемента: ");
int LookingForCalumn = int.Parse(Console.ReadLine() ?? "");

long[,] fibArray = FillingTwoDimArray(countRow, countCalumn);
PrintTwoDimArray(fibArray);
Console.WriteLine();
PrintResult(SearchNumber(fibArray));


// Метод возвращает двумерный массив заполненный числами Фибоначчи, укравшие 2 ночи моей жизни, 
// из-за которых я забыл поставить задачу на обновление маршрутизации
long[,] FillingTwoDimArray(int countRow, int countCalumn)
{
    long[,] outArray = new long[countRow, countCalumn];

    // первые 2 элемента
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            outArray[0, 0] = 0;
            outArray[0, 1] = 1;
        }
    }

    // первая строка
    for (int i = 0; i < 1; i++)
    {
        for (int j = 2; j < countCalumn; j++)
        {
            outArray[i, j] = outArray[i, (j - 1)] + outArray[i, (j - 2)];
        }
    }

    // остальной массив
    for (int i = 1; i < countRow; i++)
    {
        int j = 0;
        for (j = 0; j < countCalumn; j++)
        {
            if (j < 2)
            {
                outArray[i, 0] = outArray[(i - 1), (countCalumn - 1)] + outArray[(i - 1), (countCalumn - 2)];
                outArray[i, 1] = outArray[i, 0] + outArray[(i - 1), countCalumn - 1];
            }
            else outArray[i, j] = outArray[i, (j - 1)] + outArray[i, (j - 2)];
        }
    }
    return outArray;
}

// Метод печатующий массив
void PrintTwoDimArray(long[,] inputArray)
{
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] +  "\t");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

//метод производящий поиск элемента по позиции
bool SearchNumber (long[,] inputArray)
{
    bool result = false;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (i == (LookingForRow-1) && j == (LookingForCalumn-1))
            {
                 result = true;
            }
        }
    }
    return result;
}

//метод печатающий результат
void PrintResult (bool result)
{
    if (result) PrintColorArray(fibArray);
    else Console.WriteLine("Такого элемента в массиве нет");
}

//Метод, печатающий массив с выделенным элементом
void PrintColorArray(long[,] inputArray)
{
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            if (i == (LookingForRow-1) && j == (LookingForCalumn-1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(inputArray[i, j] + "\t");
                Console.ResetColor();
                //Console.Write();
            }
            else Console.Write(inputArray[i, j]  + "\t");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

