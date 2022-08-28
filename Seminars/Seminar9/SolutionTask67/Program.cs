/* ======================================================
 Напишите программу, которая 
 будет принимать на вход число и возвращать сумму его цифр.
 =========================================================*/

 // метод считывания данных
 int ReadData(string line)
 {
     Console.Write(line);
     return Convert.ToInt32(Console.ReadLine());
 }


 // метод вычисления суммы цмфр в числе (рекурсия)
 int SumDigit(int num)
 {
     if (num > 0)
         return num % 10 + SumDigit(num / 10);

     else
         return 0;
 }


 int inputNumber = ReadData("Задайте число: ");
 Console.WriteLine(SumDigit(inputNumber));