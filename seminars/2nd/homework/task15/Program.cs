﻿// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int day = int.Parse(Console.ReadLine());
if (day < 5)
{
    Console.Write("Этот день не выходной :(");
}
else
{
    Console.Write("Это выходной !");
}