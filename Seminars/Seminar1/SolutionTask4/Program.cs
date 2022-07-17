// Принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа

//Вариант с остатком от деления на 10 10

// string? imputLine = Console.ReadLine();
// if(imputLine != null)
// {
//    int inputNumber = int.Parse(imputLine);
 
//     int outputNumber = inputNumber%10;
 
//    Console.WriteLine(outputNumber);
// }

// Вариант с выделением подстроки с номером символа

// string? imputLine = Console.ReadLine();
// if(imputLine != null)
// {
//     string lastNum = imputLine.Substring(2,1);
 
//    Console.WriteLine(lastNum);
// }

// Вариант с массивом

string? imputLine = Console.ReadLine();
if(imputLine != null)
{
    char[] M = imputLine.ToCharArray();
    Console.WriteLine(M[2]);
}