﻿using System;

namespace Lab_9_1
{
    class Trapezium
    {
        public void Calc()
        {
            Console.Write("Введiть нижню межу = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть верхню межу = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть кiлькiсть вiдрiзкiв, на яку розбивається iнтеграл = ");
            int n = Convert.ToInt16(Console.ReadLine());
            double h, x1, x2, res, sum = 0;
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                x1 = a + i * h;
                x2 = a + (i + 1) * h;
                sum += (Math.Exp(Math.Sin(x1)) + Math.Exp(Math.Sin(x2)));
            }
            res = sum * h / 2;
            Console.WriteLine($"Вiдповiдь: {Math.Round(res, 3)}");
        }
    }
    public delegate void Fun();
    class Program
    {
        static void Main(string[] args)
        {
            Trapezium t = new Trapezium();
            Fun x = new Fun(t.Calc);
            x();
        }
    }
}
