// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
int size = 4;
int [] Array = new int [size];
int max = Array[0];
int min = Array[0];
int index = 0;
while (index < size)

{
    Array[index] = new Random().Next(0,100);
    Console.Write($"{Array[index]} ");
    if (Array[index] > max) 
    {
        max = Array[index];
    }
    else 
    {
        min = Array[index];
    }
    index++;
}
int result = max - min;


Console.Write($"-> {result}");


