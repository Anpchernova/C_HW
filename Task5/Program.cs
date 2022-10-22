// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number >= 100 && number <= 999)
{
    int a1 = number % 100;
    int a2 = a1 / 10;
    Console.WriteLine($"Вторая цифра числа {number} -> {a2}");
}
else
{
    Console.WriteLine("Введено не трёхзначное число");
}

