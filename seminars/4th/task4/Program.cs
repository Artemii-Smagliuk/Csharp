// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
// //for (int i = 0; i < 8; i++) или:
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 2);
// }

// for (int i = 0; i < 8; i++)
// {
//     Console.Write($"{array[i]}, ");
// }

// ..................Последний цикл можно ещё так записать:
// foreach(int i in array)
// {
//     Console.Write("{0}",i);
// }

//....................Или так:
//Console.WriteLine($"[{string.Join(",", array)}]");

//.......................Ещё вариант решения:
void NewAr()
{
    int[] ar = new int[8];
    for (int i = 0; i < ar.Length; i++)
    {
        ar[i] = new Random().Next(0, 2);
        Console.Write($" {ar[i]} ");
    }

}
Console.Write("[");
NewAr();
Console.Write("]");