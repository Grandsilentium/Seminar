// // Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 3267912 -> 6

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 0 & num <= 99)
{
Console.WriteLine(" -> третий цифры нет"); 
}
else if(num >= 100)
{
string numText = Convert.ToString(num);
Console.Write($" Третья цифра -> {numText[2]}");    
}








