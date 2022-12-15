// Решение в группах задач:
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int GetNumber(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int CompOfNumbers(int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result*i;
    }
    return result;
    
}

int num2 = GetNumber("Введите число: ");
int result2 = CompOfNumbers(num2);
Console.WriteLine($"Произведение чисел от 1 до {num2} равно {result2}");