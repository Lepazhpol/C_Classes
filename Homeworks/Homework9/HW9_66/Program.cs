/* ======================================================
 Задайте значения M и N. Напишите программу, которая 
 найдёт сумму натуральных элементов в промежутке от M до N.
 =========================================================*/

Console.Clear();
int sum = 0;
int numberM = ReadData("Задайте число M: ");
int numberN = ReadData("Задайте число N: ");

if (numberM < numberN)
    SumRow(numberM, numberN);
else
    SumRow(numberN, numberM);

// метод считывания данных
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "");
}


// рекурсивный метод нахождения суммы натуральных чисел на промежутке от m до n
void SumRow(int m, int n)
{
    if (m - 1 == n) Console.WriteLine(sum);
    else
    {
        sum = sum + m;
        SumRow(m + 1, n);
    }
}
