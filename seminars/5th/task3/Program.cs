// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// int[] ArratFill()
// {
//     int[] array = new int[12];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9,1000);
//     }
//     Console.WriteLine(String.Join(", ", array));
//     return array;
// }

// void Search(int num, int[]array)
// {
//     int flag = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]==num)
//         {
//         Console.WriteLine("Такое число есть");
//         flag=1;
//         break;
//         }
//     }
//     if(flag==0)
//     Console.WriteLine("Такого числа нет");
// }

// int[] test = ArratFill();
// Console.WriteLine("Введите число, которое нужно найти в массиве: ");
// int num = int.Parse(Console.ReadLine());
// Search(num,test);

// Ещё можно так решить:

int[] CreateMassive(int count, int begin, int end)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(begin, end + 1);
    }
    return array;
}

void Search(int[] arr, int number)
 {
     string answer = "Нет";
     for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]==number)
         {
            answer = "Да";
         break;
         }
    }
    
    Console.WriteLine(answer);
 }


int [] array = CreateMassive(8,-9,10);   
Console.Write("Введите число: ");
int check = int.Parse(Console.ReadLine());
Console.WriteLine($"[{string.Join(",", array)}]");
Search(array, check);