//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int GetLenght(string text)
{
    Console.WriteLine(text);
    int length = int.Parse(Console.ReadLine());
    return length;
}

void NewAr(int size)
{
    int[] ar = new int[size];
    
    for (int i = 0; i < ar.Length; i++)
    {
        ar[i] = new Random().Next(0, 99);
    }
    
    Console.WriteLine($"[{string.Join(",", ar)}]");
}


int size = GetLenght("Введите длинну массива: ");
NewAr(size);
