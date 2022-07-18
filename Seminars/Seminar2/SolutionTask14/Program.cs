// принимает на вход число и проверяет кратно ли оно одновременно и 7 и 23

string reminderSearcher(string? str)
{
    if (str != null)
    {
        try                     
        {
            string answer;
            int num = int.Parse(str);
            if (((num % 7) == 0) && ((num % 23) == 0))
            {
                answer = "кратно";
            }
            else
            {
                answer = "Не кратно";
            }
            return answer;
        }
        catch (Exception e)                 
        {
            return "Возникло исключение: " + e.Message;             
        }

    }
    return "";
}


Console.WriteLine("Введите число: ");

string? imputOne = Console.ReadLine();

Console.WriteLine(reminderSearcher(imputOne));