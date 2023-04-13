//  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два целых числа: ");
int num_1 = int.Parse(Console.ReadLine() ?? "");
int num_2 = int.Parse(Console.ReadLine() ?? "");

int max = num_1;
int min = num_2;

if (num_2 > max)
{
    max = num_2;
    min = num_1;
}
Console.WriteLine("Максимальное число -> " + max);
Console.WriteLine("Минимальное число -> " + min);