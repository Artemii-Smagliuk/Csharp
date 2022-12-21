// *Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string BinCode(int num)
{
    int var = num;
    string result = string.Empty;
    while(var>0)
    {
        result =$"{var%2}" + result;
        var=var/2;
    }
    return result;
}

Console.Write("Введите число: ");
int number =int.Parse(Console.ReadLine());
Console.WriteLine(BinCode(number));