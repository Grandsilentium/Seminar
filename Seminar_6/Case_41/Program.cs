// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();
int Count = 0;

Console.Write("Введите размер массива: ");

int arraySize = Convert.ToInt32(Console.ReadLine());

int [] Array = new int[arraySize];

Console.WriteLine(" ");

for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"Введите {i} элемент массива: ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(" ");

for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"{Array[i]} ");
    if (Array[i] < 0) Count++;
}
Console.WriteLine($"-> {Count}");
