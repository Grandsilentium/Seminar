// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();

void Method1(int number, int degree)
{

    int numberConstant = number;
    for(int i = 2; i <= degree; i++)
        {
        number = number * numberConstant;
        }
    Console.Write($"{numberConstant} ^ {degree} = {number} ");

}

Method1(2,3);


