// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

Console.Clear();

// Массив с цветами символов
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Red,ConsoleColor.Blue,ConsoleColor.DarkGreen, ConsoleColor.Yellow,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkMagenta,ConsoleColor.DarkRed, ConsoleColor.DarkYellow,
                                        ConsoleColor.Gray,ConsoleColor.Cyan,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Black,ConsoleColor.White};


 int[,] arrayBivariate = FillArray(3, 5);
 PrintColorArray(arrayBivariate);

 Console.WriteLine("Среднее арифметическое по столбцам:");
 double[] averageCalumn = AverageCalumn(arrayBivariate);
 PrintArray(averageCalumn);
 Console.WriteLine();


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

 // метод печати цветного массива (столбцы в разный цвет)
 void PrintColorArray(int[,] array)
 {

     for (int i = 0; i < array.GetLength(0); i++)
     {
         int j = 0;
         for (j = 0; j < array.GetLength(1); j++)
         {
             Console.ForegroundColor = col[j];
             Console.Write(array[i, j] + "\t");
             Console.ResetColor();
         }
         Console.WriteLine();
     }
 }


 // метод нахождения среднего арифметического в столбцах
 double[] AverageCalumn(int[,] array)
 {
     // массив для среднего арифметического по столбцам
     double[] averageCalumn = new double[array.GetLength(1)];
     for (int j = 0; j < array.GetLength(1); j++)
     {
         double sumCalumn = 0;
         for (int i = 0; i < array.GetLength(0); i++)
         {
             sumCalumn += array[i, j];
         }
         averageCalumn[j] = Math.Round((sumCalumn / array.GetLength(0)), 2);
     }
     return averageCalumn;
 }

 // Метод печати одномерного массива 
 void PrintArray(double[] array)
 {
     for (int i = 0; i < array.Length; i++)
     {
         Console.ForegroundColor = col[i];
         Console.Write(array[i] + "\t");
         Console.ResetColor();
     }
     Console.WriteLine();
 }
