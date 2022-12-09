// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());


if (num < 100)
{
    Console.Write("Третьей цифры нет :(");
}
else
{
    if (num > 100)
    {
        while (num > 1000)
        num = num / 10;
        num = num % 10;
        Console.Write("Третья цифра заданного числа: " + num);
    }
}
