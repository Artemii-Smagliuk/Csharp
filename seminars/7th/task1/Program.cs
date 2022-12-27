// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
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
            array[i,j] = new Random().Next(begin,end+1);
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

//Запрашиваем количество строк
int rows = EnterData("Введите количество строк: ");
//Запрашиваем количество столбцов
int columns = EnterData("Введите количество столбцов: ");
// Создаём двухмерный массив и заполняем его случайными числами
int[,] matrix = FillArr(rows, columns, -100, 100);
// Выводим массив на экран
PrintArr(matrix);




