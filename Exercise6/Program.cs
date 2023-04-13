// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите целое число: ");

string userNamber = Console.ReadLine() ?? "";
int Input = int.Parse(userNamber);

if (Input % 2 == 0)
{
    Console.WriteLine($"{userNamber}  ->  Является четным число");
}
else
{
    Console.WriteLine($"{userNamber}  ->  Не является четным числом");
}