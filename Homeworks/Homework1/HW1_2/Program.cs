// Принимает 2 числа и выдает какое число больше, а какое меньше

string? imputLineA = Console.ReadLine();
string? imputLineB = Console.ReadLine();

if((imputLineA+imputLineB) != null)
{

   int inputNumberA = int.Parse(imputLineA);
   int inputNumberB = int.Parse(imputLineB);

   if(inputNumberA>inputNumberB)
   {
    Console.Write("max = ");
    Console.WriteLine(inputNumberA);

    Console.Write("min = ");
    Console.WriteLine(inputNumberB);
   }
   else
   {
    Console.Write("max = ");
    Console.WriteLine(inputNumberB);

    Console.Write("min = ");
    Console.WriteLine(inputNumberA);
   }

}