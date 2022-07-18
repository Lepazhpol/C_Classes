// принмает два числа, выводит, является ли второе число кратным первому. Если второе число некратно первому, то выводит отстаток от деления
Console.WriteLine("Введите первое число: ");
string? num1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string? num2 = Console.ReadLine();

if (num1 != null && num2 != null)
{
    int numInt1 = int.Parse(num1);
    int numInt2 = int.Parse(num2);

    int div = numInt2 % numInt1;

    if (div == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет" + "Остаток: " + div);
    }
}