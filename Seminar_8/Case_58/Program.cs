// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();

int m = 2;
int n = 2;

int[,] array1 = new int[m, n];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
Console.WriteLine("Матрица 1: ");
Console.WriteLine();

FillArray(array1);
PrintArray(array1);

Console.WriteLine();


int l = 2;
int k = 2;

int[,] array2 = new int[l, k];

Console.WriteLine("Матрица 2: ");

Console.WriteLine();
FillArray(array2);
PrintArray(array2);

Console.WriteLine();
Console.WriteLine("Произведение двух матриц: ");
Console.WriteLine();
int a = (array1[0, 0] * array2[0, 0]) + (array1[0, 1] * array2[1, 0]);
int b = (array1[0, 0] * array2[0, 1]) + (array1[0, 1] * array2[1, 1]);
int c = (array1[1, 0] * array2[0, 0]) + (array1[1, 1] * array2[1, 0]);
int d = (array1[1, 0] * array2[1, 1]) + (array1[1, 1] * array2[1, 1]);

int[,] arrayMultiplication = { {a, b}, {c, d} };


PrintArray(arrayMultiplication);
Console.WriteLine();