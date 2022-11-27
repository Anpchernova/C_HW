// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

Console.Clear();
Console.WriteLine("Введите размеры матриц:");
Console.Write("Введите число строк 1-й матрицы: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int cols = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов 2-й матрицы: ");
int m = int.Parse(Console.ReadLine()!);

int[,] firstMartrix = GetArray(rows, cols, 0, 10);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMartrix);

int[,] secondMartrix = GetArray(cols, m, 0, 10);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondMartrix);

int[,] resultMatrix = new int[rows, m];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);