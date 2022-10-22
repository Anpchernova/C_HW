// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

void palindrom(int number)
{
    if (number >= 10000 && number <= 99999)
    {
        int a1 = number / 10000;
        int a2 = number % 10000 / 1000;
        int a4 = number % 100 / 10;
        int a5 = number % 10;
        if (a1 == a5 && a2 == a4)
            Console.WriteLine($"Число {number} - палиндром");
        else
            Console.WriteLine($"Число {number} - не палиндром");
    }
    else
        Console.WriteLine("Введено не пятизначное число");
}

Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
palindrom(num);