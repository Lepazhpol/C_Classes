// ----=====принимает на вход число N и выдает таблицу кубов чисел от 1 до (но без таблицы :( )=====----

Console.WriteLine("Введите число");
string? imputLineN = Console.ReadLine();

if (imputLineN != null)
{
    int numberN = int.Parse(imputLineN);
    string lineN = "";
    string lineNNN = string.Empty;
    int s = 1;

    while (s <= numberN)
    {
        lineN = lineN + s + " ";
        lineNNN = lineNNN + (s * s * s).ToString() + " ";
        s++;
    }
    Console.WriteLine(lineN);
    Console.WriteLine(lineNNN);
}