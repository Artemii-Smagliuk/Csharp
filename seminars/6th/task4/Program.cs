// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// **Числа Фибоначчи** — числовая ****последовательность, каждый элемент которой равен сумме двух предыдущих.

// void CreateArr(int []arr)
// {
//     arr[0]=0;
//     arr[1]=1;
//     for (int i = 2; i < arr.Length; i++)
//     {
//         arr[i] = arr[i-1]+arr[i-2];
//     }
//     Console.WriteLine(String.Join(" ", arr));
// }

// int GetNum(string text)
//     {
//      Console.WriteLine(text);
//      int number = int.Parse(Console.ReadLine());
//      return number;
//     }


// int num = GetNum("Введите число: ");
// int[] arr = new int[num];
// CreateArr(arr);

// Ещё можно через переменные решить:

string Fib (int num)
{
    int num1 = 0;
    int num2 = 1;
    string result = $"{num1}{num2}";
    for(int i=0;i<num -2;i++)
    {
        int temp = num1;
        num1=num2;
        num2=temp+num2;
        result = result +$"{num2}";
    }
    return result;

}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
string res=Fib(number);
Console.WriteLine(res);