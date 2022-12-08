// Напишите программу, которая выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа.

// Сгенерировать число
// Разделить на 2 переменные
// Сравнить 2 число
// Вывести число через max
Console.Clear();
int n = new Random().Next(10,100);
//Console.WriteLine(n); - просто генерация рандомного числа
int numberA = n % 10;
int numberB = n / 10;
int max = numberA;

if (max < numberB) max = numberB;
Console.WriteLine("В числе " + n + " цифра " + max + " наибольшая");
