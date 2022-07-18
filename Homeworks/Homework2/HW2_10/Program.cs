// принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Вы хотите самостоятельно ввести число? y/n: ");
string answer = Console.ReadLine();
if (answer != null)
{
    if (answer.ToLower() == "y")
    {
        Console.WriteLine("Введите трехзначное число: ");
        string stringNum = Console.ReadLine();
        Console.WriteLine(stringNum[1]);
    }
    else
    {
        int number = new Random().Next(100, 1000);
        Console.WriteLine("Случайное трехзначное число: " + number);
        string stringNum = number.ToString();
        Console.WriteLine(stringNum[1]);
    }
}