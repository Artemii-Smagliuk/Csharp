// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int Sum(int num)
{   
    int result = 0;
    for (int i = num; i >= 0; i ++)
    {
        result = result + num%10;
        num= num/10;
    }
    return result;
}

int num = GetNum("Введите число для выдачи суммы его цифр: ");
int result = Sum(num);
Console.WriteLine($"Сумма цифр в числе: {result}");