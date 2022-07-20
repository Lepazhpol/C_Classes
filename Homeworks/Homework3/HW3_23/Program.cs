// ----=====принимает на вход число N и выдает таблицу кубов чисел от 1 до (но без таблицы :( )=====----

Console.WriteLine("Введите число");
string? imputLineN = Console.ReadLine();

if (imputLineN != null)
{
    int numberN = int.Parse(imputLineN);                        //Парсим
    string lineN = "";                                          //пустоту можно и так
    string lineNNN = string.Empty;                              //и так
    int s = 1;

    while (s <= numberN)
    {
        lineN = lineN + s + " ";
        lineNNN = lineNNN + (s * s * s).ToString() + " ";       //пока у нас не наше число накапливаем и состав числа и кубы
        s++;
    }
    Console.WriteLine(lineN);
    Console.WriteLine(lineNNN);
}

// таблицу очень долго пытался, но, похоже чего-то мне не хватает(((