// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

float columnOne = 0;
float columnTwo = 0;
float columnThree = 0;
float columnFour = 0;

float[,] array = new float[4, 4];

for (int i = 0; i < св; i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j == 0)
        {
            columnOne = columnOne + array[i, j];
        }

        if (j == 1)
        {
            columnTwo = columnTwo + array[i, j];
        }
        if (j == 2)
        {
            columnThree = columnThree + array[i, j];
        }
        if (j == 3)
        {
            columnFour = columnFour + array[i, j];
        }
    }
    Console.WriteLine();
}

Console.WriteLine($"Среднее арифметическое каждого столбца: {columnOne/array.GetLength(1)} ; {columnTwo/array.GetLength(1)} ; {columnThree/array.GetLength(1)} ; {columnFour/array.GetLength(1)}");

