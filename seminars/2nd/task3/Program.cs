﻿// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
//  34, 5 -> не кратно, остаток 4
//  16, 4 -> кратно

Console.Clear();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
int del = numberA % numberB;
if (del == 0)
{
    Console.WriteLine(numberB + " кратно " + numberA);

}
else
{
        Console.WriteLine(numberB + " некратно " + ", остаток от деления равен " + del);

}





