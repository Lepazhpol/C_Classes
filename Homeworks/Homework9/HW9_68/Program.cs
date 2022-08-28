/* =================================================================
 Напишите программу вычисления функции Аккермана с помощью рекурсии. 
 Даны два неотрицательных числа m и n
==================================================================*/


Console.Clear();
int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");

if (m >= 0 && n >= 0)
{
    int result = FunctionAkkerman(m, n);
    Console.WriteLine($"Результат вычисления функции Аккермана = {result}");
}
else Console.WriteLine("Функцию Аккермана вычислить нельзя");


// метод считывания данных
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine());
}

// метод вычисления функции Аккермана 
int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return FunctionAkkerman(m - 1, 1);
    else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}




/* =================================================================
Ниже приведены другие варианты из этих ваших интернетов просто для себя
==================================================================*/


/* =================================================================
using System;
 
namespace ConsoleApp
{
    class Program
    {
        public static int Depth = 0;
        public static UInt64 AckermannFunc(UInt64 m, UInt64 n) {
            Depth++;
            if (m == 0)
                return n + 1;
            if (n == 0)
                return AckermannFunc(m - 1, 1);
            return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
        }
 
        static void Main(string[] args) {
            Console.WriteLine(AckermannFunc(3, 5));
            Console.WriteLine(Depth);
        }
    }
}

===================================================================

С ошибкой невозвращения пути (на подумать)

static int S(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (n > 0 && m == 0)
        return S(n - 1, 1);
    else if (n > 0 && m > 0)
        return S(n - 1, S(n, m - 1));
}
static void Main(string[] args)
{
    int k;
    k = S(9, 2); 
    Console.WriteLine(k);
}


==================================================================*/