using System;

namespace DSA_Lesson2
{
    class Program
    {
        static long giaiThua(int n)
        {
            //S(1) = 1! = 1
            //S(2) = 1*2 = 2! = 2
            //S(3) = 1*2*3 = 3! = 6
            //S(4) = 3!*4 = S(3) * 4
            //S(n) = S(n-1) * n
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return giaiThua(n - 1) * n;
            }       

        }
        
        static int Fibonacci(int n)
        {
            //0,1,1,2,3,5,8,13,21
            //n = (n-1) + (n-2)
            if(n <= 1) return n;
           
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static long sum1toN_recursion(int n)
        {
            if (n == 1) return 1;

            return sum1toN_recursion(n - 1) + n;
        }
        static long sum1toN_loop(int n)
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            //Giai thua
            Console.WriteLine("{0}! = {1}", n, giaiThua(n));
            //Fibonacci
            Console.WriteLine("Fibonacci{0} = {1}", n, Fibonacci(n));
            //Sum 1 to N - recursion
            Console.WriteLine("RECURSION");
            Console.WriteLine($"Tong S({n}) = {sum1toN_recursion(n)}");
            //Sum 1 to N - loop
            Console.WriteLine("LOOP");
            Console.WriteLine($"Tong S({n}) = {sum1toN_loop(n)}");

        }
    }
}
