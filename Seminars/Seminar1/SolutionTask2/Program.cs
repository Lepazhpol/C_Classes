// Выдает название дня недели по заданному номеру

string? imputLine = Console.ReadLine();

if(imputLine != null)
{
   int inputNumber = int.Parse(imputLine);

   //Очень интересно, но ничего непонятно  Надо поизучать

   string outDayOfWeek  = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));

   Console.WriteLine(outDayOfWeek);

//       string[] dayOfWeek = new string[7];
//    dayOfWeek[0] = "Понедельник";
//    dayOfWeek[1] = "Вторник";
//    dayOfWeek[2] = "Среда";
//    dayOfWeek[3] = "Четверг";
//    dayOfWeek[4] = "Пятница";
//    dayOfWeek[5] = "Суббота";
//    dayOfWeek[6] = "Воскресенье";
 
//    Console.WriteLine(dayOfWeek[inputNumber-1]);


// Вариант с использованием Case (мне не нравится)

//    switch (inputNumber)
//    {
//     case 1:
//     Console.WriteLine("Понедельник");
//     break;

//     case 2:
//     Console.WriteLine("Вторник");
//     break;

//     case 3:
//     Console.WriteLine("Среда");
//     break;

//     case 4:
//     Console.WriteLine("Четверг");
//     break;

//     case 5:
//     Console.WriteLine("Пятница");
//     break;

//     case 6:
//     Console.WriteLine("Суббота");
//     break;

//     case 7:
//     Console.WriteLine("Воскресенье");
//     break;

//    }

}
