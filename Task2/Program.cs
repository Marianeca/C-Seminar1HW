//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a;
int b;

Console.Write($"Введите число a \n");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите число b \n");
int.TryParse(Console.ReadLine()!, out b);

if (a < b)
{
    Console.Write($"max = {b}\n");
}
else
{
    Console.Write($"max = {a}\n");
}