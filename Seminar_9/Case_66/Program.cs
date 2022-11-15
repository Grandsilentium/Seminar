﻿
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите число 1:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int n = Convert.ToInt32(Console.ReadLine());


void PrintSum (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"-> {sum}"); 
        return;
    }
    sum = sum + (m++);
    PrintSum(m, n, sum);
}

PrintSum(m, n, 0);