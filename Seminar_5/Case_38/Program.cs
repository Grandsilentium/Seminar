// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
int size = 4;

int [] Array = new int [size];
for(int i = 0; i < size; i++)   
{  
   
Array[i] = new Random().Next(0,100);
Console.Write($"{Array[i]} ");

}

int max = Array[0];
int min = Array[0];


for(int j = 0; j < size; j++)   
{  
   if (Array[j] < min)   
   {
       min = Array[j];
   }
   if (Array[j] > max) 
   {
       max = Array[j];
   }
}

int result = max - min;
Console.Write($"-> {result}");


