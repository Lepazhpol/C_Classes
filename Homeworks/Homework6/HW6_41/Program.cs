//Пользователь вводит с клавиатуы М чисел. Посчитатйте, сколько чисел больше 0 ввел пользователь
Console.Clear();
PrintAnswer(SearchForPositiveNumbers(FillingArray(NumbersOfInputs())));

//Метод запрашивающий колличество введенных чисел
int NumbersOfInputs()
{
    Console.WriteLine("Введите число вводимых чисел: ");
    int numInputs = int.Parse(Console.ReadLine()?? "");
    return numInputs;
}
//Метод, заполняющий массив с числами, введенными пользователем
int[] FillingArray(int length)
{
    int[] numbersArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine("Введите число номер " + (i+1) + " " + "(" + (i+1) + "/" + length + "): ");
        numbersArray[i] = int.Parse(Console.ReadLine()?? "");
    }
    return numbersArray;
}
//Метод, находящий количство положительных чисел
int SearchForPositiveNumbers(int[] inputArray)
{
    int responseStorage = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] > 0) responseStorage += 1;
    }
    return responseStorage;
}
//Метод, выводящий количество положительных чисел
void PrintAnswer(int answer)
{
    Console.WriteLine("Число положительных чисел среди введенных: " + answer);
}
