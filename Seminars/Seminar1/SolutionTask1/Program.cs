// На вход принимает два числа и проверяет, является ли первое число квадратом второго

//Вариант 1

//string? imputLkneOne = Console.ReadLine();
//string? imputLkneTwo = Console.ReadLine();
//
//if(imputLkneOne != null && imputLkneTwo != null)
//{
//   int imputNumberOne = int.Parse(imputLkneOne);
//    int imputNumberTwo = int.Parse(imputLkneTwo);
//
//    if(imputNumberOne == imputNumberTwo * imputNumberTwo)
//   {
//        Console.WriteLine("yes");
//    }
//    else
//    {
//        Console.WriteLine("no");
//    }
//}

//Вариант 2

string? imputLkneOne = Console.ReadLine();
string? imputLkneTwo = Console.ReadLine();

if(imputLkneOne != null && imputLkneTwo != null)
{
   int imputNumberOne = int.Parse(imputLkneOne);
   int imputNumberTwo = int.Parse(imputLkneTwo);

    if(imputNumberTwo == Math.Sqrt(imputNumberOne))
   {
        Console.WriteLine("yes");
   }
   else
   {
       Console.WriteLine("no");
   }

}