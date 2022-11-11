// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Stepen(int A, int B)
{
    int num = 1;
    for (int i = 1; i <= B; i++)
    {
        num = num * A;
    }
    return num;
}

Console.Clear();
Console.Write("Введите число 1: ");
int one = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int two = int.Parse(Console.ReadLine()!);

int stp = Stepen(one, two);
Console.WriteLine(stp);
