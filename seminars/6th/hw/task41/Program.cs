// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PosNum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) { result++; }
    }
    Console.Write($"[{string.Join(",", array)}] Чисел больше нуля: ");
    Console.Write(result);
}

int[] EnterData(int[] array)
{
    int[] result = { };
    for (int i = 0; i + 1 > 0; i++)
    {
        Console.Write("Введите число, для завершения дважды нажмите Enter : ");
        string str = Console.ReadLine();
        int var = 0;
        double number;
        bool isNumber = double.TryParse(str, out number);
        if (str != "")
        {
            if (isNumber == true)
            {
                Array.Resize(ref array, i + 1);
                var = Int32.Parse(str);
                array[i] = var;
            }
        }
        if (str == "") { break; }
    }
    return array;
}

int[] arr = { };
arr = EnterData(arr);
PosNum(arr);