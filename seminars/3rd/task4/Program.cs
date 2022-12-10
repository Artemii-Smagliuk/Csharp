// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

/* Первое решение

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Sqr(int number)
{
    number=number*number;
    Console.Write(number + ", ");
}

Console.Clear();
int N = EnterData("Введите число N: ");
int i=1;
while(i<=N)
{
    Sqr(i);
    i++;
}

Второе решение


void WriteTable(int N)
{
    int i = 1;
    while(i<=N)
    {
        Console.Write(i*i + ", ");
        i++;
    }
}

Console.Clear();
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = EnterData("Введите число: ");
WriteTable(number);

Третье решение
*/
int Table(int n)
{
    int result = 1;
    for(int i = 1; i<= n; i++)
    {
        result = i*i;
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