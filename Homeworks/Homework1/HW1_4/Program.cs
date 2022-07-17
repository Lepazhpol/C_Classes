// Принимает 3 числа и выдает максимальное

string? imputLineA = Console.ReadLine();
string? imputLineB = Console.ReadLine();
string? imputLineC = Console.ReadLine();

if((imputLineA+imputLineB+imputLineC) != null)
{

   int inputNumberA = int.Parse(imputLineA);
   int inputNumberB = int.Parse(imputLineB);
   int inputNumberC = int.Parse(imputLineC);

   if(inputNumberA>inputNumberB)
   {

    if(inputNumberA>inputNumberC)

    {
        Console.Write("max = ");
        Console.WriteLine(inputNumberA);
    }
    else
    {
        Console.Write("max = ");
        Console.WriteLine(inputNumberB);
    }

   }
   else
   {
    
    if(inputNumberB>inputNumberC)
    {
        Console.Write("max = ");
        Console.WriteLine(inputNumberB);
    }
    else
    {
        Console.Write("max = ");
        Console.WriteLine(inputNumberC);
    }

   }

}