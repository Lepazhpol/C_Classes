﻿// принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным

Console.Clear();

Console.WriteLine("Введите номер дня недели (от 1 до 7): ");
int day = int.Parse(Console.ReadLine());                                //преобразуем введенные данные типа string  в int
if (day != null)                                                        //проверяем на пустоту
{
    if ((day > 1) && (day < 7))                                         //проверяем, чтобы введеные данные попадали в заданный промежуток
    {
        if ((day == 6) || (day == 7))                                   //ищем выходные
        {
            Console.WriteLine("Да, выходной");
        }
        else
        {
            Console.WriteLine("Нет, не выходной");

        }
    }
    else
    {
        Console.WriteLine("Изучите календарь");
    }
}