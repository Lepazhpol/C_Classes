// Принимает одно число, а на выходе показывает все целы числа от -n до n

Console.WriteLine("Введите число");
string? imputLkneOne = Console.ReadLine();
Console.WriteLine("Спасибо");

if(imputLkneOne != null)
{
    int imputNumber = int.Parse(imputLkneOne);
    int startNumber = 1;
    // string lineOutput = "";
    
    // while (startNumber < imputNumber);
    // {
    //     lineOutput = lineOutput+startNumber+", ";
    //     startNumber++;
    // }

    // lineOutput = lineOutput+imputNumber;

    // Console.WriteLine(lineOutput);

    string lineOutput = "0";
    
    while (startNumber <= imputNumber)
    {
        lineOutput = startNumber*(-1)+", "+lineOutput+", "+startNumber;
        startNumber++;
    }


    Console.WriteLine(lineOutput);

}
Console.WriteLine("Конец программы");