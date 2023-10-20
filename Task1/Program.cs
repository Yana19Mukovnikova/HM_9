// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;

class Program
{
    static void Main(string[] args)
    {
        int N = 5;
        PrintNumbers(N);
    }

    static void PrintNumbers(int num)
    {
       if (num == 1)
        {
            Console.WriteLine(num);
        }
        else
        {
            Console.Write(num + ", ");
            PrintNumbers(num - 1);
        }
    }
}