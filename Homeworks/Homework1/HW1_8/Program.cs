// На вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

string? imputLine = Console.ReadLine();

if(imputLine != null)
{
    int imputNumber = int.Parse(imputLine);
    int startNumber = 1;
    string lineOutput = "";
    
    while (startNumber < imputNumber)
    {
        lineOutput = lineOutput+startNumber+", ";
        startNumber++;
    }

    lineOutput = lineOutput+imputNumber;

    Console.WriteLine(lineOutput);

}