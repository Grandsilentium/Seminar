﻿// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int stepOne = num / 10;
int stepTwo = stepOne % 10;
Console.Write($" -> {stepTwo}");



