//нахождение наибольшего из 9 чисел (решение с использованием массива)

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;                          //задаем функцию, сравнивающую 3 числа
    if (arg2 > result) result = arg2;            //далее мы разбиваем наши числа по три, сравниваем их и получаем три максимума из каждой группы  затем уже сравниваем эти максимумы и получаем общий максимум
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };

int max = Max(
    Max(array[0], array[1], array[3]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);