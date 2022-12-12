// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckPal(string stroka)
{
    if (stroka.Length ==5)
    {
        if (stroka[0] == stroka [4] && stroka [1] == stroka [3])
        {
            Console.WriteLine($"Число {stroka} - палиндром !");
        }
        else
        {
            Console.WriteLine($"Число {stroka} - не палиндром :(");
        }
        
    }
    else
    {
        Console.WriteLine($"Число {stroka} состоит не из пяти цифр");

    }
}

string EnterData(string text)
{
    Console.Write(text);
    string number = Console.ReadLine();
    return number;
}

Console.Clear();
string Num = EnterData("Введите пятизначное число: ");
CheckPal(Num);
