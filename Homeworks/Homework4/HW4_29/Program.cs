// выводит массив по заданным пользователем параметрам 
System.Random numberSintezator = new Random();

//запрашиваем и принимаем параметры массива
Console.WriteLine("Введите длину массива: ");
string imputLengthLine = Console.ReadLine() ?? "";
int imputLength = int.Parse(imputLengthLine);

Console.WriteLine("Далее необходимо ввести диапазон значений массива");

Console.WriteLine("Введите начальное значение диапазона");
string imputStartLine = Console.ReadLine() ?? "";
int imputStart = int.Parse(imputStartLine);

Console.WriteLine("Введите конечное значение диапазона");
string imputEndLine = Console.ReadLine() ?? "";
int imputEnd = int.Parse(imputEndLine);

Check();

// Выводит на экран наш массив, который не массив
void Print(int Length, int start, int end)
{
    int i = 0;
    Console.Write("[");
    while (i < Length - 1)
    {
        Console.Write(numberSintezator.Next(start, end+1) + ",");
        i++;
    }
    Console.Write(numberSintezator.Next(start, end+1));
    Console.Write("]");

}

// Проводит проверку на краевые значения
void Check()
{
    if (imputStart < imputEnd) 
    {
        Print(imputLength, imputStart, imputEnd);
    }
    else
    {
        Print(imputLength, imputEnd, imputStart);
    }
}