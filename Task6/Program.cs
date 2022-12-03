//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).

int a;

Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

if (a % 2 == 0)
{ Console.Write($"Да \n"); }
else { Console.Write($"Нет \n"); }


