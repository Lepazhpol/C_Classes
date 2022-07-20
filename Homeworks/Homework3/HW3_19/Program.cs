//принимает на вход пятизначное число и проверяет, является ли оно палиндромом

//объявляем глобальные переменные
int number;
int d1;
int d2;
int d4;
int d5;

//просто разбивает введенное число по цифрам. зачем? а чтоб красиво было
void calculation()
{
    d1 = number / 10000;
    d2 = (number / 1000) % 10;
    d4 = (number / 10) % 10;
    d5 = number % 10;
}


Console.WriteLine("Введите пятизначное число");
string? numberLine = Console.ReadLine();

if (numberLine != null)
{
    number = int.Parse(numberLine);

    calculation();

    if ((d1 == d5) || (d2 == d4)) Console.WriteLine("Да, палиндром");
    else Console.WriteLine("Нет, не палиндром");
}