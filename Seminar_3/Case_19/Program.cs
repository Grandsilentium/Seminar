﻿// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (numberText[0] == numberText[4] && numberText[1] == numberText[3])
{
    Console.Write("  -> Да");
}
else
{
    Console.Write("  -> Нет");
}