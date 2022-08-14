//Определяет назодится ли введенное число в заданном массиве

//Метод возвращает массив заполненный случайными числами из промежутка от до
int[] FillingArray()
{
    int[] outArray = new int[12];
    int i = 0;
    System.Random umberSintezator = new System.Random();
    while (i < 12)
    {
        outArray[i] = umberSintezator.Next(-9, 10);
        i++;
    }
    return outArray;
}

//Метод печатающий масиив
void PrintArray(int[] inputArray)
{
    int i = 0;
    while (i < inputArray.Length - 1)
    {
        Console.Write(inputArray[i] + ", ");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}

//Метод ищущий элемент в массиве (ЛОГИЧЕСКИЙ)
bool CalculateTask(int[] inputArray, int searchNumber)
{
    bool resultSearch = false;
    int i = 0;
    while (i < 12)
    {
        if (inputArray[i]==searchNumber)
        {
            resultSearch = true;
            break;
        }
        i++;
    }
    return resultSearch;
}

int[] buferArray = FillingArray();
PrintArray(buferArray);
Console.WriteLine("Введите число для поиска: ");
int searchNumber = int.Parse(Console.ReadLine());
Console.WriteLine(CalculateTask(buferArray, searchNumber));
