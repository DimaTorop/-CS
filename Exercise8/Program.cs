// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
{
 int i = 1;
    {        bool not = true;

            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Чётные числа от 1 до " + num);
            while (i <= num)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Чётных чисел нет ");
            }
    }
}