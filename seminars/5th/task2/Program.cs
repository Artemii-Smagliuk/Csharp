// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] ChangeNum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
         arr[i] = -arr[i];
    }
    return arr;
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

int[] way = CreateMassive(12, -9, 9);
Console.WriteLine(String.Join(", ", way));
int[] change = ChangeNum(way);
Console.WriteLine(String.Join(", ", change));

