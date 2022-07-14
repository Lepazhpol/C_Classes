//Квадрат вводимого числа
 
 
string? imputLine = Console.ReadLine();
if(imputLine != null)
{
   int inputNumber = int.Parse(imputLine);
 
  // int outNumber = inputNumber*inputNumber;
   int outNumber = (int)Math.Pow(inputNumber,2);
 
   Console.WriteLine(outNumber);
}