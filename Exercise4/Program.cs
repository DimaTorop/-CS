// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 3 числа: ");
            int num_1 = int.Parse(Console.ReadLine() ?? "");
            int num_2 = int.Parse(Console.ReadLine() ?? "");
            int num_3 = int.Parse(Console.ReadLine() ?? "");

            int max = num_1;

            if (num_2 > max)
            {
                max = num_2;
            }

            if (num_3 > max)
            {
                max = num_3;
            }

            Console.WriteLine("Наибольшее из чисел -> " + max);