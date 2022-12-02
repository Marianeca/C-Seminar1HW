//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a;
int b;
int c;

Console.WriteLine($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.WriteLine($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);
Console.WriteLine($"Введите третье число: ");
int.TryParse(Console.ReadLine()!, out c);

int max = a;
{
    if (b > max) max = b;
    if (c > max) max = c;
}
Console.WriteLine(max);
