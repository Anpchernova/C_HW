// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray()
{
    int size = int.Parse(Console.ReadLine()!);
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

int FindSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int[] array = GetArray();
Console.WriteLine(String.Join(", ", array));
int sum2 = FindSum(array);
Console.WriteLine($"Сумма чисел на нечётных позициях массива равна: {sum2}");