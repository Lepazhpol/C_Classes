// Задайте двумерный массив размером m*n, заполненный случайными целыми числами

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green,
                                        ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow};

int[,] twoDimArray = FillingTwoDimArray(5,8);
PrintTwoDimArray(twoDimArray);
PrintColorTwoDimArray(twoDimArray);

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
            outArray[i,j] = numberSintezator.Next(0,101);
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
            Console.Write(inputArray[i,j]+ " ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

//Метод печатующий цветной массив
void PrintColorTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;
    Console.ForegroundColor = ConsoleColor.Yellow;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0,16)];
            Console.Write(inputArray[i,j]+ " ");
            Console.ResetColor();
            j++;
        }
        Console.WriteLine();
        i++;
    }
    Console.ResetColor();
}


