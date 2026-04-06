using System;
//Author: Hoang Khuong Duy - 2500114656
namespace DSA_Session06_Array
{
    class Program
    {
        //Bien toan cuc (global) de luu tru mang dang lam viec
        static int[] currentArray;

        static void Main(string[] args)
        {
            int choice; //Bien de luu lua chon cua nguoi dung
            do {
                Console.WriteLine("\n=================================");
                Console.WriteLine("\tMODULE QUAN LY MANG (MIDTERM)\t");
                Console.WriteLine("\n=================================");
                Console.WriteLine("1. Tao mang so ngau nhien");
                Console.WriteLine("2. In mang hien tai");
                Console.WriteLine("3. Sap xep mang (Bubble Sort)");
                Console.WriteLine("4. Tim kiem nhi phan (Binary Search)");
                Console.WriteLine("0. Thoat phan mem");
                Console.WriteLine("\n=================================");
                Console.Write("Moi ban lua chon tinh nang (0-4): ");

                //Xu ly ngoai le neu nguoi dung nhap chu thay vi so
                if (!int.TryParse(Console.ReadLine(), out choice)) {
                    Console.WriteLine("Loi: Vui long nhap so nguyen!");
                    continue; //Quay lai dau vong lap do-while
                }

                switch (choice)
                {
                    case 1:
                        GenerateRandomArray();
                        break;
                    case 2:
                        PrintArray();
                        break;
                    case 3:
                        BubbleSort();
                        break;
                    case 4:
                        ExcuteBinarySearch();
                        break;
                    case 0:
                        Console.WriteLine("Dong he thong!");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
            while (choice != 0);
        }

        // --- CAC HAM XU LY NGHIEP VU ---
        //Ham tao mang ngau nhien
        static void GenerateRandomArray() {
            Console.Write("Nhap so luong phan tu cua mang: ");
            int n;
            // SUA LOI: Bo bot dau ngoac don thua o Console.ReadLine()
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Loi: vui long nhap 1 so nguyen duong!");
            }
            currentArray = new int[n];
            Random rand = new Random(); //Tao doi tuong Random de sinh so ngau nhien

            for (int i = 0; i < n; i++) {
                currentArray[i] = rand.Next(1, 100); //Tao so ngau nhien tu 1 den 99
            }
            Console.WriteLine($"=> Da tao mang thanh cong voi {n} phan tu!");
        }

        //Ham in mang hien tai
        static void PrintArray() {
            if (currentArray == null) {
                Console.WriteLine("Loi: Mang chua duoc khoi tao. Hay chon chuc nang 1 truoc!");
                return;
            }
            Console.Write("Du lieu mang: ");
            foreach (int num in currentArray) {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        //Ham sap xep mang - Bubble Sort
        static void BubbleSort() {
            if (currentArray == null) {
                Console.WriteLine("Loi: Mang rong!");
                return;
            }
            int n = currentArray.Length;
            for (int i = 0; i < n - 1; i++) {
                for (int j = 0; j < n - i - 1; j++) {
                    if (currentArray[j] > currentArray[j + 1]) {
                        int temp = currentArray[j];
                        currentArray[j] = currentArray[j + 1];
                        currentArray[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("=> Da sap xep mang tang dan bang Bubble Sort!");
        }

        //Ham thuc hien tim kiem nhi phan (Binary Search)
        static void ExcuteBinarySearch() {
            if (currentArray == null) {
                Console.WriteLine("Loi: Mang rong!");
                return;
            }
            Console.Write("Nhap so can tim: ");
            int target;
            while (!int.TryParse(Console.ReadLine(), out target)) {
                Console.WriteLine("Loi: Vui long nhap 1 so nguyen!");
            }

            //Thuat toan Binary Search
            int left = 0;
            int right = currentArray.Length - 1;
            int pos = -1; //Bien luu vi tri, -1 co nghia la chua tim thay

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (currentArray[mid] == target) {
                    pos = mid;
                    break;
                }
                if (currentArray[mid] < target) {
                    left = mid + 1; //bo qua nua trai
                }
                else {
                    right = mid - 1; //bo qua nua phai
                }
            }

            if (pos != -1)
                Console.WriteLine($"=> Da tim thay so {target} tai vi tri Index = {pos}.");
            else
                Console.WriteLine($"=> Khong tim thay so {target} trong mang (Luu y: Mang phai duoc sap xep truoc khi tim nhi phan!)");
        }
    }
}