/* =================================================================
 Задайте значение N. 
 Напишите программу, которая выведет все натуральные числа от N до 1
 ==================================================================*/

Console.Clear();
int stopCount = 1;
int inputNumber = ReadData("Задайте число: ");
ReverseRow(stopCount, inputNumber);

// метод считывания данных
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "");
}


// рекурсивный метод вывода ряда от N до 1
void ReverseRow(int count, int number)
{
    if (count > number) return; // условие выхода из рекурсии 
    else
    {
        // показывает ход рекурсии 
        Console.WriteLine(count);
        // метод вызывает сам себя с инкрементом
        ReverseRow(count + 1, number);
        Console.Write(count + " ");
    }
}
