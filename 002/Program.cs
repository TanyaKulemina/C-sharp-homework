/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetSum (int m, int n)
{
    if(m <= n) 
        return m + GetSum (m+1, n);
    else
        return 0;
}
int m = 1;
int n = 15;
int sum = GetSum(m, n);
Console.WriteLine (sum);