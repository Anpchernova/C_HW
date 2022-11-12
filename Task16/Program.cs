// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] GetArray()
{
    int size = int.Parse(Console.ReadLine()!);
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1, 100);
    }
    return res;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

Console.Clear();
Console.WriteLine("Введите размер массива: ");
double[] array = GetArray();
Console.WriteLine(String.Join(", ", array));
double Max = FindMax(array);
double Min = FindMin(array);
double Dif = Max - Min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {Dif}");