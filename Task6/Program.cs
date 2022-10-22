// Напишите программу, которая выводит третью цифру (справа налево) заданного числа 
//или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number >= 100)
{
    int a1 = number % 1000;
    int a2 = a1 / 100;
    Console.WriteLine($"Третья цифра числа {number} -> {a2}");
}
else
{
    Console.WriteLine($"У числа {number} нет третьей цифры");
}