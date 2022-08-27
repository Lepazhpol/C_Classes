/*=======================================================================
 Заполните спирально массив 4 на 4.
 ========================================================================*/

 int[,] arraySnake = FillArraySnake(4, 4);
 PrintArray(arraySnake);
 Console.WriteLine();


 // метод заполнения спирального двумерного массива 
 int[,] FillArraySnake(int countRow, int countCalumn)
 {
     int quantityElement = countRow * countCalumn;
     //int counter = 1;
     int i=0, j=0;
     int[,] outArray = new int[countRow, countCalumn];
     for (int counter = 1; counter <= quantityElement; counter++)
     {
         outArray[i, j] = counter;
         if (i <= j + 1 && i + j < outArray.GetLength(1) - 1)
             j++;
         else if (i < j && i + j >= outArray.GetLength(0) - 1)
             i++;
         else if (i >= j && i + j > outArray.GetLength(1) - 1)
             j--;
         else
             i--;
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
