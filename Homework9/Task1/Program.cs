﻿// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
void Rec(int n)
{
	if (n == 0)
		return;
	if (n > 0)
	{
		Console.Write($"{n} ");
	}
	Rec(n - 1);

}
Rec(n);