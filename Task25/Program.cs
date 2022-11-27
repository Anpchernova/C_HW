// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetArray(int m, int n, int l, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, l];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }

    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}{(i, j, k)} \t");
            }
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите число строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
Console.Write("Введите число третьего измерения: ");
int m = int.Parse(Console.ReadLine()!);
int[,,] array = GetArray(rows, cols, m, 10, 100);
PrintArray(array);