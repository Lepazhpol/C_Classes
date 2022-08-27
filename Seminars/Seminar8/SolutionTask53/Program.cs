// Задайте двумерный массив, напишите программу которая поменяет первую и последнюю строку массива

int[,] twoDimArray = FillingTwoDimArray(3,4);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();
PrintTwoDimArray(RotateRowFirstLast(twoDimArray));



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
            Console.Write(inputArray[i, j] + "\t");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

// Метод меняет местами первую и последнюю строку двумерного массива
// Принимает двумернуый массив
// возвращает модифицированный входной массив
int[,] RotateRowFirstLast(int[,] inputArray)
{
    int bufferElement = 0;
    int i = 0; int j = 0;
    Console.ForegroundColor = ConsoleColor.Yellow;
    while (j < inputArray.GetLength(1))
    {
        // Блок ротации элементов в столбце
        bufferElement = inputArray[0,j];
        inputArray[0,j] = inputArray[inputArray.GetLength(0)-1,j];
        inputArray[inputArray.GetLength(0)-1,j] = bufferElement;
        j++;
    }
    return inputArray;
}