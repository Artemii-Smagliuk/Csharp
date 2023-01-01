// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int EnterData(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int m = EnterData("Введите число m: ");
int n = EnterData("Введите число n: ");
Console.WriteLine("A(m,n) = " + Akkerman(m, n));