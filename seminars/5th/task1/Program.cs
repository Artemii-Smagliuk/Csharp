// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int SumNumber(int[] arr, bool symbol)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (symbol)
        {
            if (arr[i] > 0)
            {
                sum = sum + arr[i];
            }
        }
        else
        {
            if (arr[i] < 0)
            {
                sum = sum + arr[i];
            }
        }
    }
    return sum;
}

int[] CreateMassive(int count, int begin, int end)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(begin, end + 1);
    }
    return array;
}

//создать массив из 12 случайных чисел
int[] way = CreateMassive(12, -9, 9);
Console.WriteLine(String.Join(", ", way));
// найти сумму положительных чисел
int sumPlus = SumNumber(way, true);
// найти сумму отрицательных чисел
int sumMinus = SumNumber(way, false);
Console.WriteLine($"сумма положительных чисел равна {sumPlus}, сумма отрицательных равна {sumMinus}");

