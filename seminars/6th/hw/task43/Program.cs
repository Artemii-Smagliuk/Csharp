// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Intersec(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * x) + b2;
    Console.WriteLine($"[b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}] Точка пересечения этих двух прямых: ({x}; {y})");
}

double EnterData(string text)
{
    Console.Write(text);
    double var = double.Parse(Console.ReadLine());
    return var;
}

double b1 = EnterData("Задайте значение b1: ");
double k1 = EnterData("Задайте значение k1: ");
double b2 = EnterData("Задайте значение b2: ");
double k2 = EnterData("Задайте значение k2: ");
Intersec(k1, b1, k2, b2);