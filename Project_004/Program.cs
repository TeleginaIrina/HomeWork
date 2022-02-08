// 4 задача. Найти max из трёх чисел.


int numA = new Random().Next(1,99);;
Console.WriteLine($"Первое число {numA}");

int numB = new Random().Next(1,99);;
Console.WriteLine($"Второе число {numB}");

int numC = new Random().Next(1,99);;
Console.WriteLine($"Третье число {numC}");

int max = numA;

if (max < numB) max = numB;
if (max < numC) max = numC;

Console.WriteLine($"Максимальное из трёх чисел: {max}");