using System;
using System.Diagnostics;

//Author: Hoang Khuong Duy - 2500114656
//Muc tieu:

namespace DSA_Session04_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai 1: Loi chao thong minh
            //Code:
            //Su dung Console.ReadLine() de gan bien
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhap ho ten: ");
            String name = Console.ReadLine();
            Console.Write("Nhap MSSV: ");
            String mssv = Console.ReadLine();
            Console.WriteLine($"Chao mung sinh vien {name} (MS: {mssv} den voi lop CTDL&GT!)");

            //Bai 2: May tinh co ban
            //Yeu cau: Nhap 2 so nguyen a va b. Tinh va in ra Tong, Hieu, Tich, Thuong
            //Huong dan: Du lieu tu ban phim luon la string
            //Dung int.Parse() de chuyen ve so nguyen truoc khi tinh toan
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tong: {a + b}");
            Console.WriteLine($"Hieu: {a - b}");
            Console.WriteLine($"Tich: {a * b}");
            if(b != 0)
                Console.WriteLine($"Thuong: {(double)a / b}");
            else
                Console.WriteLine("Khong the chia cho 0!\n");       
            
            //Bai 3: Ky thuat Hoan doi (Swap)
            //Yeu cau: cho 2 bien x = 5, y = 10. Hay doi gia tri cua chung x = 10, y = 5
            //Huong dan: su dung 1 bien temp de luu gia tri tam thoi
            int x = 5, y = 10;
            Console.WriteLine($"Truoc khi swap: x = {x}, y = {y}");
            int temp = x; //temp = 5
            x = y;        //x = 10
            y = temp;     //y = 5
            Console.WriteLine($"Sau khi swap: x = {x}, y = {y}");
        }

        

    }
}
