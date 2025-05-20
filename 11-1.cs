using System;

namespace OverloadApp
{
    class Program
    {
        // 多載：計算 int 立方
        public static int Cube(int x)
        {
            return x * x * x;
        }

        // 多載：計算 double 立方
        public static double Cube(double x)
        {
            return x * x * x;
        }

        // 多載：三個整數取最小值
        public static int MinElement(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }

        // 多載：四個整數取最小值
        public static int MinElement(int a, int b, int c, int d)
        {
            return Math.Min(a, Math.Min(b, Math.Min(c, d)));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Cube(3) = " + Cube(3));
            Console.WriteLine("Cube(2.5) = " + Cube(2.5));
            Console.WriteLine("MinElement(4, 7, 2) = " + MinElement(4, 7, 2));
            Console.WriteLine("MinElement(9, 3, 6, 1) = " + MinElement(9, 3, 6, 1));
        }
    }
}