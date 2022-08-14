//Приниамет на вход число и выдает сумму цифр в числе

Console.Clear();
int t1;
int t2;
Console.WriteLine("Введите число");
string imputNumLine = Console.ReadLine() ?? "";

//выводим результат через числа и замеряем время
t1 = Environment.TickCount;
MetodInteger ();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t1);

//выводим результат через строки и замеряем время
t2 = Environment.TickCount;
MetodString ();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t2);

//результата анализа
if (t1<t2) Console.WriteLine("Через числа быстрее");
else Console.WriteLine("Через строки быстрее");



//решает задачу через числа
void MetodInteger ()
{
    int num = int.Parse(imputNumLine);
    int result = 0;
    while (num > 0)
    {
        result = result + (num%10);
        num = num/10;
    }
    Console.WriteLine(result);
}

//решает задачу через строки
void MetodString ()
{
    int length = imputNumLine.Length;
    char[] array = imputNumLine.ToCharArray();
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        result = result + int.Parse(array[i].ToString());
    }
    Console.WriteLine(result);
}


