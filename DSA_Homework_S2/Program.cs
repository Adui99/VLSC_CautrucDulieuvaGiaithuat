using System;

namespace DSA_Homework_S2
{
    class Program
    {
        //Ham de quy tinh tong S(n)
        static int TinhTong(int n)
        {
            if (n == 1) return 1;

            return n + TinhTong(n - 1);
        }

        //Ham giai thua - loop
        static long GiaiThuaVongLap(int n)
        {
            long ketQua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketQua *= i;
            }
            return ketQua;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhap n de tinh tong: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tong S({n}) = {TinhTong(n)}");
            Console.WriteLine($"Giai thua cua {n} la {GiaiThuaVongLap(n)}");

        }
    }
}
