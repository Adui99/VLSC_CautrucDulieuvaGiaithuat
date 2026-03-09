using System;

namespace DSA_Lesson1
{
    class SinhVien
    {
        public string HoTen { get; set; }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            // ---BAI TAP 1: HIEU VE THAM CHIEU (REFERENCE)---
            Console.WriteLine("=== Bai tap 1: tham chieu ===");
            SinhVien sv1 = new SinhVien { HoTen = "Hoang Khuong Duy" };

            // sv2 khong tao vung nho moi, no chi "tro" cung vao dia chi cua sv1
            SinhVien sv2 = sv1;

            sv2.HoTen = "Nguyen Ngoc Tien"; // Thay doi qua sv2

            //Ket qua in ra sv1 se la "Nguyen Ngoc Tien" vi ca 2 dung chung dia chia Heap
            Console.WriteLine($"Ten cua sv1 sau khi thay doi qua sv2: {sv1.HoTen}");


            // ---BAI TAP 2: HOAN DOI GIA TRI VOI TU KHOA 'ref'---
            // 'ref' cho phep ham truy cap truc tiep vao dia chi vung nho cua bien goc
            // tren Stack, giup hoan doi gia tri ma khong can tra ve ket qua
            Console.WriteLine("\n=== Bai tap 2: Hoan doi (Swap) ===");
            int a = 10, b = 20;
            Console.WriteLine($"Truoc khi Swap: a = {a}, b = {b}");

            Swap(ref a, ref b); // Phai co tu khoa 'ref' khi goi ham

            Console.WriteLine($"Sau khi Swap: a = {a}, b = {b}");

            // --- BAI TAP 3: THAO TAC MANG VA HIEU NANG ---
            // Mang la kieu tham chieu. Truy xuat mang qua index co do phuc tap O(1).
            Console.WriteLine("\n=== Bai tap 3: Thao tac mang ===");
            int[] numbers = {1, 2, 3, 4, 5};

            PrintArray(numbers);
        }

        // Giai thich bai 2: Dung 'ref' de tac dong vao vung nho Stack cua bien truyen vao
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // Giai thich bai 3: Duyet mang thong qua chi so (Index)
        static void PrintArray(int[] arr)
        {
            Console.WriteLine("Cac phan tu trong mang: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
