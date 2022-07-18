// выводит случайное трехзначное число и удаляет вторую цифру этого числа

// Вариант 1

void solutionVithDigits()
{
    Console.WriteLine("Вариант 1");
    int number = new Random().Next(100, 1000);
    Console.WriteLine("Число: " + number);
    int numberSecondDigit = number / 100;
    int numberThirdDigit = number % 10;
    Console.WriteLine("Число после удаления второй цифры: " + numberSecondDigit + numberThirdDigit);
}

void solutionVithStrings()
{
    int numberS = new Random().Next(100, 1000);
    Console.WriteLine("Случайное число: " + numberS);
    string stringNum = numberS.ToString();
    Console.WriteLine(stringNum);
    Console.Write(stringNum[0]);
    Console.Write(stringNum[2]);
}

solutionVithDigits();
solutionVithStrings();