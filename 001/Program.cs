﻿/* 
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int n = 8;
int Array(int n)
{
	if(n == 1) return n;
	else return Array(n-1) + 1;
}

for (int i = n; i >= 1; i--)
{
	Console.Write($"{Array(i)}, ");
}