// ----=====принимает на вход координаты двух точек и находит расстояние между ними в 3Д пространстве=====----


/////// вариант без звездочки, чтобы была формально выполнена задача
int coordXpointA;
int coordYpointA;
int coordZpointA;

int coordXpointB;
int coordYpointB;
int coordZpointB;

double lengthAB;

//считывает координаты точек А и В
void readDataOfPoint()
{
    Console.WriteLine("Введите координату Х для точки А");
    coordXpointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y для точки А");
    coordYpointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z для точки А");
    coordZpointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Х для точки B");
    coordXpointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y для точки B");
    coordYpointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z для точки B");
    coordZpointB = int.Parse(Console.ReadLine());
}

//Вычисляет расстояние между точками А и В
void calculateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXpointA - coordXpointB), 2) + Math.Pow((coordYpointA - coordYpointB), 2) + Math.Pow((coordZpointA - coordZpointB),2));
}

readDataOfPoint();
calculateLengthAB();

Console.WriteLine(lengthAB);


// ////////////////Вариант со * но не работает со всеми случаями(((
// //преобразует введенное пользователем в массив с числами
// int[,,] parsingCoord(string coordPLine)
// {
//     //разбираем координаты точки А
//     string coordXLine = coordPLine.Substring(0, coordPLine.IndexOf(","));
//     //Console.WriteLine(coordAXLine);

//     string coordYLine = coordPLine.Substring(coordPLine.IndexOf(",")+1, coordPLine.IndexOf(","));
//     //Console.WriteLine(coordYLine);

//     string coordZLine = coordPLine.Substring(coordPLine.IndexOf(",")+1);
//     coordZLine = coordZLine.Substring(coordZLine.IndexOf(",")+1);
//     //Console.WriteLine(coordZLine);

//     //Парсим значения
//     int coordX = int.Parse(coordXLine);
//     int coordY = int.Parse(coordYLine);
//     int coordZ = int.Parse(coordZLine);
    
//     //Суем в массив
//     int[,,] arrayOut = new int[1, 2, 3];
//     arrayOut[0, 0, 0] = coordX;
//     arrayOut[0, 1, 0] = coordY;
//     arrayOut[0, 0, 1] = coordZ;   

//     return arrayOut;
// }



// Console.WriteLine("Введите координаты точки А и В в следующем формате: 'A(3,6,8); B(2,1,-7)':");

// string imputLine = Console.ReadLine();

// //пользователь ввел данные в таком формате "A(3,6,8); B(2,1,-7)" растаскиваем значения в скобках на А и В

// string coordALine = imputLine.Substring(imputLine.IndexOf("A(")+2, imputLine.IndexOf(");")-2);
 
// string coordBLine = imputLine.Substring(imputLine.IndexOf("B") + 1);
// coordBLine = coordBLine.Substring(coordBLine.IndexOf("(") + 1, coordBLine.IndexOf(")")-1);

// //Console.WriteLine(coordALine+" "+coordBLine);

// //сейчас у нас есть координаты точки А в формате "3,6,8" и В "2,1,-7"

// int[,,] arrayCoordA = parsingCoord(coordALine);
// int[,,] arrayCoordB = parsingCoord(coordBLine);

// //вычисляем искомое значение
// double lengthAB = Math.Sqrt(Math.Pow((arrayCoordA[0,0,0] - arrayCoordB[0,0,0]), 2) + Math.Pow((arrayCoordA[0,1,0] - arrayCoordB[0,1,0]), 2) + Math.Pow((arrayCoordA[0,0,1] - arrayCoordB[0,0,1]),2));

// Console.WriteLine(lengthAB);

