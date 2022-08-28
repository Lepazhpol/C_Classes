
 /* =================================================================
 Задайте значение N. 
 Напишите программу, которая выведет все натуральные числа от 1 до N
 ==================================================================*/

Console.Clear();

 int ReadData()
 {
     Console.Write("Задайте число: ");
     return int.Parse(Console.ReadLine());
 }


 int NuturalNumberPrinter(int number)
 {    
     if (number == 2) return 1; // остановка метода. крайний случай в рекурсии. условие остановки рекурсии 
     else
     {
         // уменьшаем число на 1
         number--;
         // печатает ход рекурсии
         Console.WriteLine(number);
         // вызываем метод внутри метода (метод вызывает сам себя), но с уменьшенным на 1 числом
         Console.Write(NuturalNumberPrinter(number) + " ");
     }
     return number;
 }

 int inputNumber = ReadData();
 // +2 чтобы включить предпоследнее и последнее числа в ряду 
 NuturalNumberPrinter(inputNumber+2);


