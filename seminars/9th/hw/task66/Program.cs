// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NaturalNum(int m, int n)
{
    if(m == n) return m;
    else return (m + NaturalNum(m+1, n));
}

int EnterData(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int m = EnterData("Введите число m : ");
int n = EnterData("Введите число n : ");
Console.WriteLine(NaturalNum(m,n));