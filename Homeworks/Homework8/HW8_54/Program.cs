/*=======================================================================
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию (хотя в примере явно по возрастанию, делаем как в примере)
элементы каждой строки двумерного массива.
========================================================================*/

int[,] arrayBivariate = FillArray(AskUser("Задайте числов строк массива: "), AskUser("Задайте число столбцов массива: "));
PrintArray(arrayBivariate);
Console.WriteLine();

Console.WriteLine("Упорядоченный массив:");
PrintArray(RiseRow(arrayBivariate));
Console.WriteLine();

//метод опроса пользователя
int AskUser(string ask)
{
    Console.WriteLine(ask);
    int answer = int.Parse(Console.ReadLine() ?? "");
    return answer;
}


// метод заполнения двумерного массива 
int[,] FillArray(int countRow, int countCalumn)
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
void PrintArray(int[,] array)
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

// метод сортировки элементов строк по возростанию  
int[,] RiseRow(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            int k = 0;
            int temp = 0;
            // алгоритм сортировки строки методом вставками 
            for (k = j; k > 0; k--)
            {
                if (array[i, k] < array[i, k - 1])      //если надо изменить сортировку, меняем знак тут
                {
                    temp = array[i, k - 1];
                    array[i, k - 1] = array[i, k];
                    array[i, k] = temp;
                }
                else
                    break;
            }
        }
    }
    return array;
}

