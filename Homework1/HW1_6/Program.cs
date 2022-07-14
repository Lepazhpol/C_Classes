// Принимает число и опеределяет является ли оно четным или нет

string? imputLineA = Console.ReadLine();

if((imputLineA) != null)
{

   int inputNumberA = int.Parse(imputLineA);
   
   if((inputNumberA%2)==0)
   {
    Console.WriteLine("yes");
   }
   else
   {
    Console.WriteLine("no");
   }


}