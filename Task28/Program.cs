// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Sum(int M, int N)
{
    if (N == M - 1) return 0;
    return N + Sum(M, N - 1);
}

Console.Clear();
Console.Write("Введите число 1: ");
int Number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int Number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{Sum(Number1, Number2)}");