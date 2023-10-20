// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

class Program
{
    static void Main()
    {
        int M = 1;
        int N = 15;
        int sum = 0;

        for (int i = M; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {sum}");

        M = 4;
        N = 8;
        sum = 0;

        for (int i = M; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {sum}");
    }
}
