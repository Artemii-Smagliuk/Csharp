// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int FindDif(int a, int b)
{
    int dif = 0;
    dif = a-b;
    return dif;
}


int FindMin(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<min)
        {
            min = arr[i];
        }
    }
    return min;
}



int FindMax(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>max)
        {
            max = arr[i];
        }
    }
    return max;
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


int[] newArr = CreateArr(5, 1, 100);
//Console.WriteLine(String.Join(", ", newArr));
Console.WriteLine($"[{string.Join(" ", newArr)}]");
int max = FindMax(newArr);
int min = FindMin(newArr);
int result = FindDif(max,min);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {result}");