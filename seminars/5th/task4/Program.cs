// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// void AddArray(int[] array)
// {
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(0, 1000);
//         Console.Write($"{array[i]} ");
//     }
// }

// void FindNum(int[] col)
// {
//     int size = col.Length;
//     int rightNum = 0;
//     for (int i = 0; i < size; i++)
//     {
//         if (col[i] > 10 && col[i] < 99)
//         {
//             rightNum++;
//         }
//     }

//     Console.WriteLine();
//     Console.WriteLine("Количество чисел в интервале от 10 до 99: " + rightNum);
// }

// int[] a = new int[123];
// Console.Write("[ ");
// AddArray(a);
// Console.Write(" ]");
// FindNum(a);

// Второе решение:

int Change(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] < 100)
        {
            res = res + 1;
        }
    }

    return res;
}

int[] CreateMassive(int count, int begin,  int end)
{
    int [] array = new int [count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(begin,end);
    }
    return array;
}
int[] array = CreateMassive(12,0,150);
Console.WriteLine(String.Join(" ",array));
int change = Change(array);
Console.WriteLine(change);
