// Напишите программу, которая на вход принимает число и ищет его в двумерном массиве. 
// Программа должна возвращать значение позиции (номер строки и столбца) этого элемента или же указание, 
// что такого элемента нет.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void SearchNumber(int[,] inArray)
{
    Console.WriteLine("Введите число: ");
    int N = int.Parse(Console.ReadLine()!);
    int k = -1;
    int l = -1;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (N == inArray[i, j])
            {
                k = i;
                l = j;
                Console.WriteLine($"Число в массиве находится на позиции {(k, l)} \t");
                break;
            }
        }
    }
    if (k == -1 &  l == -1) Console.WriteLine("Такого значения в массиве нет");
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во стобцов: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, cols, 0, 100);
PrintArray(array);
SearchNumber(array);
