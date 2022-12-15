// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B (без использования Math.Pow).
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int NatDeg(int a, int b)
{
    int deg = a;
    for (int count = 1; count < b; count++)
    {
        deg = deg * a;
    }
    return deg;
}

int a = GetNum("Введите число A: ");
int b = GetNum("Введите число B: ");
int result = NatDeg(a,b);
Console.Write($"Число {a} в степени {b} равняется {result}");
