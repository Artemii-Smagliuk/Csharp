// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int ChangeArr(int[,] matrix, int rows, int columns)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
            sum += matrix[i, j];
        }
    }
    return sum;
}

void PrintArr(int[,] arr, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FillArr(int rows, int columns, int begin, int end)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)

    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(begin, end);
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");
int[,] matrix = FillArr(rows, columns, 1, 10);
PrintArr(matrix, rows, columns);
int sum = ChangeArr(matrix, rows, columns);
Console.WriteLine($"Сумма элементов главной диагонали: {sum}");


