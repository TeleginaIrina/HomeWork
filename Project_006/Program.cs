// 6 задача. Выяснить, является ли число чётным.

Console.WriteLine("Введите любое целое число: ");
string numberStr = Console.ReadLine();
double num = int.Parse(numberStr);

if (num % 2 == 0) Console.WriteLine($"Число {num} является чётным");
else
{
    Console.WriteLine($"Число {num} не является чётным");
}