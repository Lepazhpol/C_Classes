// Принимает два числа (А и В) и возводит число А в натуральную степень В

Print();

//Запрашивает число А
int Read1()
{
    Console.WriteLine("Введите число А: ");
    string imputALine = Console.ReadLine() ?? "";
    int A = int.Parse(imputALine);
    return A;
}

//Запрашивает число В
int Read2()
{
    Console.WriteLine("Введите число B: ");
    string imputBLine = Console.ReadLine() ?? "";
    int B = int.Parse(imputBLine);
    return B;
}

//Возводит в степень
double Calculate (int num1, int num2)
{
    double result = Math.Pow(num1, num2);       //Тип дабл!!!
    return result;
}

//Выводит на экран
void Print()
{
    Console.WriteLine(Calculate(Read1(), Read2()));
}