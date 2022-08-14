//Создает массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9] и находит количество отрицательных и положительных элементов массива

int posetiveSum = 0;
int negativeSum = 0;

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

void ColculateTask(int[] outArray)
{
    int i = 0;
    while (i < 12)
    {
        if (outArray[i] > 0)
        {
            posetiveSum++;
        }
        else
        {
            negativeSum++;
        }
        i++;
    }
}

void PrintResult()
{
    Console.WriteLine(posetiveSum);
    Console.WriteLine(negativeSum);
}

void VariantNaive()
{
    int[] bufferArray = FillingArray();
    ColculateTask(bufferArray);
    PrintResult();
}

VariantNaive();
