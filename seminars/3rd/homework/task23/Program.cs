// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Table(int n)
{
    int result = 1;
    for(int i = 1; i<= n; i++)
    {
        result = i*i*i;
        Console.Write($"{result}, ");
    }
    return result;
}

int EnterData(string text)
{
    Console.Write(text);
    int n = int.Parse(Console.ReadLine());
    return n;
}

Console.Clear();
int n = EnterData("Введите число: ");
int result = Table(n);