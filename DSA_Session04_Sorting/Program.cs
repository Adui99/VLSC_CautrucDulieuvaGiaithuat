using System;
using System.Diagnostics;

//Author: Hoang Khuong Duy - MSSV: 2500114656
//Muc tieu: Hoc cach su dung cac thuat toan sap xep co ban: Bubble Sort, Selection Sort, Insertion Sort.
namespace DSA_Session04_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Thiet lap ma hoa dau ra de ho tro Tieng Viet co dau
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Bai 1: Sap xep noi bot (Bubble Sort)
            //Yeu cau: Nhap vao 1 mang so nguyen, dung Bubble Sort de sap xep mang tang dan
            //Huong dan: Bubble Sort hoat dong bang cach so sanh tung cap phan tu lien ke va hoan doi chung neu sai thu tu
            //Lap lai qua trinh nay den khi mang duoc sap xep hoan toan
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            //Khoi tao mang va nhap gia tri
            int[] arr = new int[n];
            Console.WriteLine("Nhap gia tri cac phan tu:");
            //Su dung vong lap de nhap gia tri tung phan tu cua mang
            for (int i = 0; i < n; i++){
                Console.Write($"arr[{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            //Goi ham Bubble Sort de sap xep mang
            BubbleSort(arr);
            Console.WriteLine("Mang sau khi sap xep bang Bubble Sort:");
            //In mang sau khi sap xep
            PrintArray(arr);
            //Insertion Sort (Sap xep chen)
            InsertionSort(arr);
            Console.WriteLine("\nMang sau khi da sap xep bang Insertion Sort:");
            PrintArray(arr);
        }

            //Bubble Sort sap xep theo thu tu tang dan
        static void BubbleSort(int[] arr){
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++){
                for (int j = 0; j < n - i - 1; j++){
                    if (arr[j] > arr[j + 1]){
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }  
        }

            //PrintArray. Ham de in mang
        static void PrintArray(int[] arr){
            for (int i = 0; i < arr.Length; i++){
                Console.Write($"arr[{i}] = {arr[i]}  ");
            }
        }

            //Insert Sort (Sap xep chen)
            //Yeu cau: Nhap vao 1 mang so nguyen, su dung thuat toan Insertion Sort de sap xep mang tang dan
            //Huong dan: InsertionSort hoat dong bang cach chia mang
            //thanh 2 phan: phan da sap xep va phan chua sap xep. Thuat toan se lay tung phan tu chua sap xep va chen no
            //vao vi tri thich hop trong phan da sap xep.
        static void InsertionSort(int[] arr){
            int n = arr.Length;
            //Vong lap bat dau tu phan tu thu 2 (index 1) den cuoi mang
            for (int i = 1; i < n; i++){
                //Luu gia tri cua phan tu hien tai de chen vao vi tri thich hop
                int key = arr[i];
                //Bien j de duyet nguoc lai phan da sap xep
                int j = i - 1;
                //Di chuyen cac phan tu lon hon key sang phai
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                //Chen key vao vi tri thich hop
                arr[j + 1] = key;
            }
        }
    }
}
