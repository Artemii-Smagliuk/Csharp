// Решение в группах задач:
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// string GetNumber(string text)
// {
//     Console.Write(text);
//     string c = Console.ReadLine();
//     return c;
// }

// string number = GetNumber("Введите число: ");
// int count = number.Length;
// Console.WriteLine(count);

// Второй вариант решения:

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while(n>0)
// {
//     n/=10;
//     count ++;
// }
// Console.WriteLine($"Количество цифр в числе = {count}");

// Третий вариант решения:

int AmmountOfDigits(int b)
{
    int sum = 0;
    while (b > 0)
    {
        b = b / 10;
        sum = sum + 1;
    }
    return sum;
}

int GetNumber(string text)
{
    Console.Write(text);
    int x = int.Parse(Console.ReadLine());
    return x;
}

int b = GetNumber("Введите число: ");
int num = AmmountOfDigits(b);
Console.WriteLine("Количество цифр в числе: " + num);