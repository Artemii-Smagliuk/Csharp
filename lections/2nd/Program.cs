// Задача: Найти максимальное из 9ти чисел

/* 
..........."Стихийный", длинный метод

Console.Clear();
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 233;
int c3 = 3323;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine (max); */

// .................Дальше вариант с функцией (в C# она называется метод)

/*Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 2338;
int c3 = 33;

 int max1 = Max(a1,b1,c1);
 int max2 = Max(a2,b2,c2);
 int max3 = Max(a3,b3,c3);

 int max = Max(max1,max2,max3);

 Console.WriteLine ($"Максимальное число {max}");

/*Это же можно записать короче:

int max = Max(
    Max(a1,b1,c1),
    Max(a2,b2,c2),
    Max(a3,b3,c3)
);
Console.WriteLine ($"Максимальное число {max}"); */

// ........................................А теперь массивы

//              0  1   2   3   4   5  6  7  8
//int[] array = {11,122,434,434,3434,8,98,664,7};
//array[0] = 111;
/* А показать что в ячейке массива можно вот так:
Console.WriteLine(array[3]);
*/
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);
*/

//.................................Задача с массивом и счётчиком(найти ячейку числа массива)
/*
int[] array = {1,3,44,333,44,3,98,6};
int n = array.Length;
int find = 44;
int index = 0;

while (index < n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}

*/
//....................Ещё с массивами (создали массив, заполнили рандомными числами и распечатали)
void FillArray(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);      
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);

//Ещё нужно разобрать применение вышенаписанного к задаче