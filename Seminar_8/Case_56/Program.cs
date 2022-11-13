// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int m = 4;
int n = 4;
int FirstRow = 0;
int SecondRow = 0;
int ThirdRow = 0;
int FourthRow = 0;

int[,] array = new int[m, n];

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
FillArray(array);
PrintArray(array);



for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == 0)
        {
            FirstRow += array[i, j];
        }

        if (i == 1)
        {
            SecondRow += array[i, j];
        }
        if (i == 2)
        {
            ThirdRow += array[i, j];
        }
        if (i == 3)
        {
            FourthRow += array[i, j];
        }
    }
}

int RowNumber = 0;

int min = FirstRow;
if (FirstRow < min)
{
    min = FirstRow;
    RowNumber = 1;
}
if (SecondRow < min)
{
    min = SecondRow;
    RowNumber = 2;
}
if (ThirdRow < min)
{
    min = ThirdRow;
    RowNumber = 3;
}
if (FourthRow < min)
{
    min = FourthRow;
    RowNumber = 4;
}

Console.WriteLine();

Console.WriteLine(FirstRow);
Console.WriteLine(SecondRow);
Console.WriteLine(ThirdRow);
Console.WriteLine(FourthRow);
Console.WriteLine();

Console.WriteLine($"строка: {RowNumber}, значение {min}");

