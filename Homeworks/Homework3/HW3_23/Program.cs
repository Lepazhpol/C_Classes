// принимает на вход число N и выдает таблицу кубов чисел от 1 до N

// Решение, чтобы было хоть какое-то решение

// string? imputLineN = Console.ReadLine();

// if (imputLineN != null)
// {
//     int numberN = int.Parse(imputLineN);
//     string lineN = "";
//     string lineNNN = string.Empty;
//     int s = 1;

//     while (s <= numberN)
//     {
//         lineN = lineN + s + " ";
//         lineNNN = lineNNN + (s * s * s).ToString() + " ";
//         s++;
//     }
//     Console.WriteLine(lineN);
//     Console.WriteLine(lineNNN);
// }




// Решение в таблице

string? imputLineN = Console.ReadLine();

if (imputLineN != null)
{
    int numberN = int.Parse(imputLineN);
    string lineN = "|";
    string lineNN = "|";
    int s = 1;

    while (s <= numberN)
    {
        lineN = lineN + s + " |";
        lineNN = lineNN + (s * s).ToString() + " |";
        s++;
    }

    int lengthString = lineN.Length();


    Console.WriteLine(lengthString);
    Console.WriteLine(lineN);
    Console.WriteLine(lineNN);
}
