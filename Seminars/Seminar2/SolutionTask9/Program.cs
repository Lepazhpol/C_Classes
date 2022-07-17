//Выводит случайное число из отрезка от 10 до 99 и показывает наибольшую цифру числа

System.Random numberSintezator = new Random();

// метод решения задачи вариант 1


int number = numberSintezator.Next(10,100);

Console.WriteLine(number);

// вариант 1

int firstNumber = number/10;
int secondNumber = number % 10;

if(firstNumber>secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}

// Вариант 2

int numberK = new Random().Next(10, 100);

Console.Write("Случайный номер: ");
Console.WriteLine(numberK);

string stringNum = numberK.ToString();

Console.Write("Наибольшая цифра: ");
if(stringNum[0] > stringNum[1])
{
    Console.WriteLine(stringNum[0]);
}
else
{
    Console.WriteLine(stringNum[1]);
}

// Вариант 3

char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();

Console.WriteLine(digits);

firstNumber = ((int)digits[0])-48;
secondNumber = ((int)digits[1])-48;

int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;

Console.WriteLine(resultNumber);