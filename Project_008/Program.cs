﻿// 8 задача. Показать чётные числа от 1 до N.

Console.WriteLine("Введите число N: ");
string numN = Console.ReadLine();
int number = int.Parse(numN);
int min = 2;
while (min < number)
{
    if (min % 2 == 0) Console.Write($"{min} ");
    min++;
}
