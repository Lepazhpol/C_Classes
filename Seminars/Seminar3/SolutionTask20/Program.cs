// принимает на вход координаты двух точек и находит расстояние между ними в 2Д пространстве

int coordXpointA;
int coordYpointA;
int coordXpointB;
int coordYpointB;
double lengthAB;

//считывает координаты точек А и В
void readDataOfPoint()
{
    Console.WriteLine("Введите координату Х для точки А");
    coordXpointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y для точки А");
    coordYpointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Х для точки B");
    coordXpointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y для точки B");
    coordYpointB = int.Parse(Console.ReadLine());
}

//Вычисляет расстояние между точками А и В
void calculateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXpointA - coordXpointB), 2) + Math.Pow((coordYpointA - coordYpointB), 2));
}

readDataOfPoint();
calculateLengthAB();

Console.WriteLine(lengthAB);

