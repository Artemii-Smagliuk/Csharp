///Типы методов

//.............................1. Ничего не возвращает и не принимает
// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1();

//........................2.Ничего не возвращает, но принимает
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения"); (остановить зацикливание - Ctrl C)

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Текст", 4);  Так тоже можно записать:
// Method21(count: 4, msg : "Новый текст");

//................................3.Возвращает, но ничего не принимает
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year  = Method3();
// Console.WriteLine(year);

//............................4.Возвращает и принимает
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i< count)
//     {
//         result = result + text;
//         i++;
//     } 
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

//То же самое, только с счётчиком for:
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

// Цикл в цикле (Таблица умножения)
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// ......................................Сортировка массива
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    
    for (int i = 0; i < array.Length ; i++)
   {
         int minPosition =i;
        for (int j = i+1; j < array.Length - 1; j++)
        {
            if(array[j]<array[minPosition]) minPosition = j;
        }
         int tempporary = array[i];
         array [i]= array[minPosition];
         array[minPosition] = tempporary;
     }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);