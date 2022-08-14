// принимает число N и выдает произведение чисел от 1 до N

Console.WriteLine("Введите число: ");

string? imputLine = Console.ReadLine();
int inputNum = int.Parse(imputLine);

Console.WriteLine(sumNums(inputNum));

int sumNums(int num)
{
    int sum = 1;
    for (int i = 1; i <= inputNum; i++)
    {
        sum *= i;
    }
    return sum;
}

// решение с рекурсией

int mulRec (int num)
{
    if (num == 1) return 1;
    else return num * mulRec (num - 1);
}