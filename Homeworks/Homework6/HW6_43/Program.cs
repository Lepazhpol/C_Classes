//Считает площадь треугольника, образованного от пересечения прямых, определяемых уравнениями y=k1*x+b1, y=k2*x+b2, y=k3*x+b3

//x = ((b2-b1)/(k1-k2)) y=k1(((b2-b1)/(k1-k2))+b1)

int k1, k2, k3, b1, b2, b3;
double x1, x2, x3, y1, y2, y3;

СoordinatesСollection();
//координаты Х точек пересечения
x1 = XIntersectionCalculation(b1, b2, k1, k2);
x2 = XIntersectionCalculation(b2, b3, k2, k3);
x3 = XIntersectionCalculation(b1, b3, k1, k3);
//координаты У точек пересечения
y1 = YIntersectionCalculation(b1, b2, k1, k2);
y2 = YIntersectionCalculation(b2, b3, k2, k3);
y3 = YIntersectionCalculation(b1, b3, k1, k3);
//треугольник с вершинами А(х1,у1), В(х2,у2), С(х3, у3)
Console.WriteLine("Площадь треугольника: " + AreaofaTriangle(SideOfTriangle(x1, x2, y1, y2), SideOfTriangle(x2, x3, y2, y3), SideOfTriangle(x3, x1, y3, y1)));

//запрос кооффициентов от пользователя
void СoordinatesСollection()
{
    Console.WriteLine("Необходимо ввести переменные k и b для уровнений y=k*x+b, определяющих три прямые");

    Console.WriteLine("Введите k1: ");
    k1 = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Введите k2: ");
    k2 = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Введите k3: ");
    k3 = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Введите b1: ");
    b1 = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Введите b2: ");
    b2 = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Введите b3: ");
    b3 = int.Parse(Console.ReadLine() ?? "");
}

//вычисляет координату Х пересечения
//b -> a, k -> c
double XIntersectionCalculation(int a1, int a2, int c1, int c2)
{
    double x = ((a2 - a1) / (c1 - c2));
    return x;
}

//вычисляет координату У пересечения
//b -> a, k -> c
double YIntersectionCalculation(int a1, int a2, int c1, int c2)
{
    double y = c1*(((a2 - a1) / (c1 - c2)) + c1);
    return y;
}

//вычисляет длину стороны
double SideOfTriangle(double coordXpointA, double coordXpointB, double coordYpointA, double coordYpointB)
{
    double lengthAB = Math.Sqrt(Math.Pow((coordXpointA - coordXpointB), 2) + Math.Pow((coordYpointA - coordYpointB), 2));
    return lengthAB;
}

//Вычисляет площадь треугольника методом Герона
double AreaofaTriangle (double lengthAB, double lengthBC, double lengthCA)
{
    double p = (lengthAB + lengthBC + lengthCA)/2;
    double area = Math.Sqrt(p * (p-lengthAB)*(p-lengthBC)*(p-lengthCA));
    return area;
}