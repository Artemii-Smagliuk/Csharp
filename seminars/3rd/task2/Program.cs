// Напишите программу, которая по заданному номеру четверти
// показывает диапазон возможных координат точек в этой четверти (x и y).

/*
void WriteQuater(int quater)
{
    if (quater == 1) { Console.WriteLine("Диапазон X от 0 до + бесконечности, а диапазон Y от 0 до + бесконечности"); }
    if (quater == 2) { Console.WriteLine("Диапазон X от 0 до - бесконечности, а диапазон Y от 0 до + бесконечности"); }
    if (quater == 3) { Console.WriteLine("Диапазон X от 0 до - бесконечности, а диапазон Y от 0 до - бесконечности"); }
    if (quater == 4) { Console.WriteLine("Диапазон X от 0 до + бесконечности, а диапазон Y от 0 до - бесконечности"); }
}

Console.Clear();
Console.Write("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine());
WriteQuater(number);


Другой вариант решения:*/

string range(int number)
{
    string text = "";
    if (number == 1) text = "x больше 0, Y больше 0";
    if (number == 2) text = "x меньше 0, Y больше 0";
    if (number == 3) text = "x меньше 0, Y меньше 0";
    if (number == 4) text = "x больше 0, Y меньше 0";
    return text;
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

Console.Clear();
int number = EnterData("Введите номер четверти: ");
string var = range(number);
Console.WriteLine(var);