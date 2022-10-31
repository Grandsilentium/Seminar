﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Clear();

int[,] array = new int[4, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.Write($"Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());


if (m < 0 | m > array.GetLength(0) - 1 | n < 0 | n > array.GetLength(1) - 1)
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    Console.WriteLine($"-> {array[m, n]}");
}

