// **Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// ❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.

// int EnterData(string text)
// {
//     Console.WriteLine(text);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// void CheckCondition(int a, int b, int c)
// {
//     if(a+b>c && a+c>b&& c+b>a)
//         Console.WriteLine("Да");
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }

// int a = EnterData("Введите число 1: ");
// int b = EnterData("Введите число 2: ");
// int c = EnterData("Введите число 3: ");
// CheckCondition(a,b,c);

// Решение с bool:

bool Teorema(int a, int b,int c)
{
    bool answer = false;
    if(a+b>c && a+c>b&& c+b>a)
    {
        answer = true;
    }
    return answer;

}

int GetNum(string text)
    {
     Console.WriteLine(text);
     int number = int.Parse(Console.ReadLine());
     return number;
    }

int a = GetNum("Введите число: ");
int b = GetNum("Введите число: ");
int c = GetNum("Введите число: ");
if (Teorema(a,b,c))
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");
