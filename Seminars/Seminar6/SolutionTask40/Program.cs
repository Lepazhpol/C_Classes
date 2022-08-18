//Принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины

int sideA = 0;
int sideB = 0;
int sideC = 0;

ReadSides();
bool res = TestTriangle(sideA, sideB, sideC);
PrintAnswer(res);

void ReadSides()
{
    Console.WriteLine("Введите длину первого отрезка: ");
    sideA = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Введите длину второго отрезка: ");
    sideB = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Введите длину третьего отрезка: ");
    sideC = int.Parse(Console.ReadLine() ?? "");
}

bool TestTriangle(int sideA, int sideB, int sideC)
{
    bool answer = ((sideA + sideB > sideC) && (sideB + sideC > sideB) && (sideA + sideC > sideB)) ? true : false;
    // переменная = (условие) ? значение 1 : значение 2;
    return answer;
}

void PrintAnswer(bool answer)
{
    if (answer) Console.WriteLine("Из эти отрезков можно составить треугольник");
    else Console.WriteLine("Из эти отрезков нельзя составить треугольник");
}