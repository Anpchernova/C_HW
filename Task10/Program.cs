// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void numberCub(int number)
{
    int index = 1;
    while (index <= number)
    {
        if (index < number)
        {
            Console.Write($"{Math.Pow(index, 3)}, ");
            index++;
        }
        else
        {
            Console.Write($"{Math.Pow(index, 3)} ");
            index++;
        }
    }
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
numberCub(num);