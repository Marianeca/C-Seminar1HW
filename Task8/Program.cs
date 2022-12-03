// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int N;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

int a = 1;
while (a <= N)
{
    if (a % 2 == 0)
    {
        Console.WriteLine($"{a}");
    }
    a++;
}
