// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

class Program {
    static int Ackermann(int m, int n) {
        if (m == 0)
            return n + 1;
        else if (m > 0 && n == 0)
            return Ackermann(m - 1, 1);
        else if (m > 0 && n > 0)
            return Ackermann(m - 1, Ackermann(m, n - 1));
        else
            return -1; // Рекурсия не может быть применена к отрицательным числам
    }

    static void Main(string[] args) {
        Console.WriteLine("Введите два неотрицательных числа:");

        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Аккерман({m}, {n}) = {Ackermann(m, n)}");
    }
}