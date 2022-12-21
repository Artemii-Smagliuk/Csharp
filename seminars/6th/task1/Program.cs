// **Задача 39:** Напишите программу, 
// которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void ReverseArr(int[] array)
{
    for(int i = 0; i< array.Length/2; i++)
    {
        int vp = array[i];
        array[i] = array[array.Length-i-1];
        array[array.Length-i-1] = vp;
    }
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

int[] arr = CreateArr(20, -10, 11);
Console.WriteLine(String.Join(", ", arr));
ReverseArr(arr);
Console.WriteLine(String.Join(", ", arr));
