// принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N

string? imputLineN = Console.ReadLine();

if (imputLineN != null)
{
    int numberN = int.Parse(imputLineN);
    string lineN = "";
    string lineNN = string.Empty;
    int s = 1;

    while (s <= numberN)
    {
        lineN = lineN + s + " ";
        lineNN = lineNN + (s * s).ToString() + " ";
        s++;
    }
    Console.WriteLine(lineN);
    Console.WriteLine(lineNN);
}