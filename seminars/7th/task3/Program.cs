// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] ChangeArr(int[,] matrix, int rows, int columns)
{
    for (int i = 1; i < rows; i++)
    {
        for (int j = 1; j < columns; j++)
        {
            if (i % 2 != 0 & j % 2 != 0)
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
    return matrix;
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
            array[i, j] = new Random().Next(begin, end+1);
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
Console.WriteLine();
int[,] newmatrix = ChangeArr(matrix, rows, columns);
PrintArr(newmatrix, rows, columns);



