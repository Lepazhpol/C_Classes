//Принимает на вход число А и выдает сумму чиссел от 1 до А
Console.Clear();
Console.Write("Введите число: ");

int t;

int imputnumber = int.Parse(Console.ReadLine());

void VariantSimple()
{
    long sumOfNumbers = 0;
    for (int i = 1; i <= imputnumber; i++)
    {
        sumOfNumbers += i; //тоже самое что и sumOfNumbers = sumOfNumbers + i;
    }
    Console.WriteLine("Сумма чисел от 1 до " + imputnumber + " = " + sumOfNumbers);
}

void VariantGauss()
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + imputnumber) * imputnumber) / 2;
    Console.WriteLine("Сумма чисел от 1 до " + imputnumber + " = " + sumOfNumbers);
}

t = Environment.TickCount; //системное время компьютера в момент выполнения этой строки

VariantSimple();

Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
VariantGauss();

Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);