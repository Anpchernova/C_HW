// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

String NaturalNumbers(int N)
{
    if (N == 1) return N.ToString();
    return $"{N}, {NaturalNumbers(N - 1)}";
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{NaturalNumbers(n)}");