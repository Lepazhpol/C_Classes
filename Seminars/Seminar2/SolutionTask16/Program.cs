// принимает на вход два числа и проверяет, является ли одно число квадратом другого
Console.Clear();

Console.WriteLine("Введите первое число: ");
string? imputFirst = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string? imputSecond = Console.ReadLine();

if((imputFirst != null) && (imputSecond != null))
{
    int imputNumberFirst = int.Parse(imputFirst);
    int imputNumberSecond = int.Parse(imputSecond);
    int a = imputNumberFirst * imputNumberFirst;
    int b = imputNumberSecond * imputNumberSecond;
    if ((a == imputNumberSecond) || (b == imputNumberSecond))
    {
        Console.WriteLine("Yes!");
    }
    else
    {
        Console.WriteLine("No!");

    }
}