// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] GetArray()
{
    int size = int.Parse(Console.ReadLine()!);
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число: ");
        res[i] = int.Parse(Console.ReadLine()!);
    }
    return res;
}

int PlusNumbers(int[] array)
{
    int countIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            countIndex += 1;
        }
    }
    return countIndex;

}

Console.Clear();
Console.WriteLine("Введите количество чисел, которые хотите проверить: ");
int[] array = GetArray();
Console.WriteLine(String.Join(", ", array));
int countIndex = PlusNumbers(array);
Console.WriteLine($"Среди введенных чисел - {countIndex} числа больше 0");