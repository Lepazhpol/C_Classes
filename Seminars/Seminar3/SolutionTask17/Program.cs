// Принимает на вход координаты точки (х и у), причем х != 0 и у != 0 и выдает номер четверти плоскости в которой находится точка

// Метод считывает точки и возвращает массив с ним
int[,] readPoint()
{
    string imputLine = Console.ReadLine();

    //x=34; y=-30     -   в таком формате пользователь вводит данные по заданию

    string coordXLine = imputLine.Substring(0, imputLine.IndexOf(";"));   //у нас строковая переменная. мы в подстроке ищем символ ;. Таким образом в переменной окажется "х=34". То есть конструкция "imputLine.Substring(0,imputLine.IndexOf(;))" кладет то, что находится между 0 и ;
    coordXLine = coordXLine.Substring(coordXLine.IndexOf("=") + 1);            //сейчас в переменной х=34. эта строка берет все что после равно

    string coordYLine = imputLine.Substring(imputLine.IndexOf(";") + 1);
    coordYLine = coordYLine.Substring(coordYLine.IndexOf("=") + 1);

    // Console.WriteLine(coordXLine+" "+coordYLine);

    int coordX = int.Parse(coordXLine);
    int coordY = int.Parse(coordYLine);

    int[,] arrayOut = new int[1, 2];
    arrayOut[0, 0] = coordX;
    arrayOut[0, 1] = coordY;


    return arrayOut;
}

// метод печатает номер четверти
void printQuter(int[,] arrayPoint)
{
    if (arrayPoint[0, 0] > 0 && arrayPoint[0, 1] > 0)
        Console.WriteLine("1 четверть");

    if (arrayPoint[0, 0] < 0 && arrayPoint[0, 1] > 0)
        Console.WriteLine("2 четверть");

    if (arrayPoint[0, 0] < 0 && arrayPoint[0, 1] < 0)
        Console.WriteLine("3 четверть");

    if (arrayPoint[0, 0] > 0 && arrayPoint[0, 1] < 0)
        Console.WriteLine("4 четверть");
}

int[,] arreyPoint = readPoint();

printQuter(arreyPoint);

//printQuter(readPoint());