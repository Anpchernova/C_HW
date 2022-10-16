// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
int max = 1;
if (number1 > number2)
    Console.WriteLine($"Число {number1} наибольшее, а число {number2} наименьшее");
if (number1 < number2)
    Console.WriteLine($"Число {number2} наибольшее, а число {number1} наименьшее");
else
    Console.WriteLine("Числа равны");