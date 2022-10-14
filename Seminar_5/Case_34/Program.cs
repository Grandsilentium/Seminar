// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.Clear();

int size = 4;
int index = 0;
int Count = 0;

int [] Array = new int [size];

while (index<size)
{
    Array[index] = new Random().Next(100,999);
    Console.Write($"{Array[index]}  ");
    if (Array[index] % 2 == 0) Count = Count + 1;
    index++;
}
Console.Write($"-> {Count}");