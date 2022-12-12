// Про методы(функции)

// Напишите программу которая принимает на вход координаты точки(X и Y)
// причём X не равно 0 и  Y не равно 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

// Сам метод:

int FindQuarter(int x, int y)
{
    int result = 0;
    if (x > 0 && y > 0) result = 1;
    if (x < 0 && y > 0) result = 2;
    if (x < 0 && y < 0) result = 3;
    if (x > 0 && y < 0) result = 4;
    return result;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Запрашиваем координаты
int x = EnterData("Введите координаты X: ");
int y = EnterData("Введите координаты Y: ");
// Анализируем данный
int number = FindQuarter(x, y);
// Вывод информации
Console.WriteLine("Ваши координаты находятся в " + number + " четверти");