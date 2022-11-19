// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int[] GetArray1()
{
    int size = 2;
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите переменные первой прямой: ");
        res[i] = int.Parse(Console.ReadLine()!);
    }
    return res;
}
int[] GetArray2()
{
    int size = 2;
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите переменные второй прямой: ");
        res[i] = int.Parse(Console.ReadLine()!);
    }
    return res;
}

void TochkaPeresecheniya(int[] array1, int[] array2)
{
    int b1 = array1[0];
    int k1 = array1[1];
    int b2 = array2[0];
    int k2 = array2[1];
    double x, y;
    if (b1 == b2 & k1 == k2) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2) Console.WriteLine("Прямые паралелльны друг другу");
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых {(x, y)}");
    }
}

Console.Clear();
int[] array1 = GetArray1();
int[] array2 = GetArray2();
TochkaPeresecheniya(array1, array2);