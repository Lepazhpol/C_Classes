// Выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Clear();

Console.WriteLine("Введите число для поиска в нем третьей цифры: ");
string numStr = Console.ReadLine();
if (numStr != null)
{
    char[] numArray = numStr.ToCharArray();
    if (numArray.Length >= 3)
    {
        Console.WriteLine("Третья цифра этого числа: " + numArray[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}