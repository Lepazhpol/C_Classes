// по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (х и у)

void printAnswer(int number)
{
    if(number == 1) Console.WriteLine("Допустимо: x>0, y>0");
    if(number == 2) Console.WriteLine("Допустимо: x<0, y>0");
    if(number == 3) Console.WriteLine("Допустимо: x<0, y<0");
    if(number == 4) Console.WriteLine("Допустимо: x>0, y,0");
}

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int imputNumber = int.Parse(inputLine);

    printAnswer(imputNumber);

}