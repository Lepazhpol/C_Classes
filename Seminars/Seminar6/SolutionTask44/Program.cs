//не используя рекурсию выведете первые N чисел Фибоначчи. Первые два числа 0 и 1

Console.WriteLine("Введите количество чисел в ряде Фибоначчи: ");
int decemalNumber = ReadDecemalNumber();
PrintAnswer(Fibonacci(decemalNumber));

int ReadDecemalNumber()
{
    return int.Parse(Console.ReadLine() ?? "");
}

string Fibonacci(int n)
{
    string answer = "";
    if (n == 2) answer = "0 1";
    else if (n == 1) answer = "0";
    else
    {
        answer = "0 1";
        int fn_1 = 1;
        int fn_2 = 0;
        int fn;
        for (int i=0; i < n - 2; i++)
        {
            fn = fn_1 + fn_2;
            answer += " " + fn;
            fn_2 = fn_1;
            fn_1 = fn;
        }
    }
    return answer;
}

void PrintAnswer(string answer)
{
    Console.WriteLine("Ряд того что я терпеть не мог в матане: " + answer);
}