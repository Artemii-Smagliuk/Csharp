// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
Console.Clear();

Console.Write("Введите первое число ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int numB = int.Parse(Console.ReadLine());

if (numA == numB*numB || numB == numA*numA)
{
    Console.Write("Одно число является квадратом другого");
}
else
{
    Console.Write("Ни одно число не является квадратом другого");
    
}


