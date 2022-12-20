// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Num(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2<=0)
        {    
            sum = sum + 1;
        }
        
    }
    return sum;
}


int[] CreateArr(int count, int begin, int end)
{
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(begin, end + 1);
    }
    return arr;
}

int[] arr = CreateArr(5, 100, 999);
Console.WriteLine(String.Join(", ", arr));
int result = Num(arr);
Console.WriteLine($"Количество чётных чисел в массиве: {result}");

