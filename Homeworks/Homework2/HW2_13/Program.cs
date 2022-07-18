// Выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Clear();

Console.WriteLine("Введите число для поиска в нем третьей цифры: ");
string numStr = Console.ReadLine();
if (numStr != null)                                                     //проверяем на пустоту
{
    char[] numArray = numStr.ToCharArray();                             //создаем массив
    if (numArray.Length >= 3)                                           //проверяем, чтобы цифр в числе было не меньше трех
    {
        Console.WriteLine("Третья цифра этого числа: " + numArray[2]);  //выводим третий элемент массива
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}