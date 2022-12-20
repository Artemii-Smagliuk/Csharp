// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SumNum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int[] CreateArr(int count, int begin, int end)
{
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(begin, end);
    }
    return arr;
}


int[] arr = CreateArr(5, -100, 101);
Console.WriteLine(String.Join(", ", arr));
int result = SumNum(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result}");