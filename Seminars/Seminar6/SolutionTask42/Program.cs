// преобразует десятичное число в двоичное

Console.WriteLine(Convert.ToString(int.Parse(Console.ReadLine()),2));

//int.Parse(Console.ReadLine()) - считываем введенное число, парсим в интеджер

//Convert.ToString(int число, 2) - где 2 основание, разрядность системы в которую переводится число. основание только 2, 8, 16

//