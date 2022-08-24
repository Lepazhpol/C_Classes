//// Задайте двумерный массив размером mxn, заполненный случайными вещественными числами. вывести цветными символами

// Массив с цветами символов
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Red,ConsoleColor.Blue,ConsoleColor.DarkGreen, ConsoleColor.Yellow,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkMagenta,ConsoleColor.DarkRed, ConsoleColor.DarkYellow,
                                        ConsoleColor.Gray,ConsoleColor.Cyan,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Black,ConsoleColor.White};


Console.Clear();
int[] sizeArray = AskUser();
double[,] twoDimArray = FillingTwoDimArray(sizeArray[0],sizeArray[1]);
PrintColorTwoDimArray(twoDimArray);



// Метод опроса пользователя
int[] AskUser()
{
    int[] answerUser = new int[2];
    Console.WriteLine("Введите размерность массива.");
    Console.WriteLine("Введите число строк двумерного массива: ");
    answerUser[0] = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Введите число столбцов двумерного массива: ");
    answerUser[1] = int.Parse(Console.ReadLine() ?? "");
    return answerUser;
}

// Метод возвращает двумерный массив заполненный случайными числами (с округлением до х знаков после запятой)
double[,] FillingTwoDimArray(int countRow, int countColumn)
{
    
    int i = 0; int j = 0;
    double[,] outArray = new double[countRow, countColumn];
    System.Random numberSintezator = new System.Random();
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i,j] = Math.Round(((numberSintezator.NextDouble())*100), 4);      // Math.Round(число, число знаков после запятой)
            j++;
        }
        i++;
    }
    return outArray;
}

// Метод печатующий цветной массив
void PrintColorTwoDimArray(double[,] inputArray)
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