//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

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

int FindNumbers(int[] array)
{
    int countIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countIndex += 1;
        }
    }
    return countIndex;
}

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int[] array = GetArray();
Console.WriteLine(String.Join(", ", array));
int countIndex2 = FindNumbers(array);
Console.WriteLine($"В массиве {countIndex2} чётных чисел");