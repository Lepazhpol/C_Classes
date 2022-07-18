// принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.Clear();

Console.WriteLine("Вы хотите самостоятельно ввести число? y/n: ");      //заморачиваемся и даем выбор, хотя и не просили
string answer = Console.ReadLine();
if (answer != null)                                                     //проверяем на пустоту
{
    if (answer.ToLower() == "y")                                        //проверяем ответ пользователя
    {
        Console.WriteLine("Введите трехзначное число: ");
        string stringNum = Console.ReadLine();
        if (stringNum != null)
        {
            if (stringNum.Length == 3)                                  //проверяем, чтоб число было трехзначным
            {
                Console.WriteLine(stringNum[1]);                        //выводим второй элемент строки
            }
            else
            {
                Console.WriteLine("Вот и давай после этого свободу людям... Просили же трехзначное. Когда машины восстанут, Вы будете первым...");
            }                                
        }
    }
    else
    {
        int number = new Random().Next(100, 1000);                      //генерируем случайное трехзначное число
        Console.WriteLine("Случайное трехзначное число: " + number);
        string stringNum = number.ToString();                           //преобразуем в строку, потому что решаем через строки
        Console.WriteLine(stringNum[1]);
    }
}