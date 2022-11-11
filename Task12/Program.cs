// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Program(int N)
{
    int sum = 0;
    int A = 0;
    while(N != 0)
    {
        A = N % 10;
        N = N/10;
        sum = sum + A;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

int Sum = Program(n);
Console.WriteLine(Sum);
