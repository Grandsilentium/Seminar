// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.Clear();

int size = 4;
int index = 0;
int sum = 0;

int [] Array = new int [size];

while (index<size)
{
    Array[index] = new Random().Next(-10,100);
    Console.Write($"{Array[index]}  ");
    if (index % 2 != 0) sum = sum + Array[index];
    index++;
}
Console.Write($"-> {sum}");