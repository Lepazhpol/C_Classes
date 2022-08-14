//Принимает число и выдает количество цифр в числе

Console.Clear();
Console.Write("Введите число: ");

string imputLineNumber = Console.ReadLine() ?? "";
int imputnumber = int.Parse(imputLineNumber);
DateTime timePoint = DateTime.Now;

int VariantChar()
{
    // int numberLength = 0;

    // char[] array = imputLineNumber.ToCharArray();        // аналогично написанному
    // numberLength = array.Length;
    return imputLineNumber.ToCharArray().Length;
}

int VariantSimple()
{
    int numberLength = 0;
    int digits = 1;
    while (digits < imputnumber)
    {
        digits = digits * 10;
        numberLength++;
    }
    return numberLength;
}

int VariantLog10()
{
    return (int)Math.Log10(imputnumber) + 1;
}

int result = 0;

timePoint = DateTime.Now;
result = VariantChar();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
result = VariantSimple();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
result = VariantLog10();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);