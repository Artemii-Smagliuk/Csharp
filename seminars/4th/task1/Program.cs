//Напишите программу, которая принимает на вход число (А)
//и выдаёт сумму чисел от 1 до А

//Принять число
//Написать метод, где в цикле находим сумму чисел
//Вывод результата
int SummOfNumbers(int a)
{
    int sum = 0;
    for (int count = 0; count <= a; count++)
    {
        sum = sum + count;
    }
    return sum;
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int c = int.Parse(Console.ReadLine());
    return c;
}



int a = GetNumber("Введите число: ");
int summ = SummOfNumbers(a);
Console.WriteLine($"Полученная сумма: {summ}");
