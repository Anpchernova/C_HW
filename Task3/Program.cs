// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int a = number % 2;

if (a == 0)
    Console.WriteLine("Число чётное");
else
    Console.WriteLine("Число нечётное");
