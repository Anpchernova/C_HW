// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number >= 1 && number <= 7)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Данный день выходной");
    }
    else
    {
        Console.WriteLine("Данный день рабочий");
    }
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}

