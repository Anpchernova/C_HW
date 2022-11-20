// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
double[,] result = new double[m, n];

for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
result[i, j] = new Random().Next(minValue, maxValue + 1);
}
}

return result;
}

void PrintArray(double[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
Console.Write($"{inArray[i,j]} \t");
}
Console.WriteLine();
}
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во стобцов: ");
int cols = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, cols, 0, 5);
PrintArray(array);
