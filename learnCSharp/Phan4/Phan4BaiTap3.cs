using System;
using System.Text;

class Phan4BaiTap3 {
    static void nhap(int[] a, int n) {
        for (int i = 0; i < n; i++) {
            Console.Write("a[" + i + "]=");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    
     static void xuat(int[] a, int n) {
        Console.Write("Hiển thị mảng:");
        for (int i = 0; i < n; i++)
            Console.Write(a[i] + " ");
    }
    
    public static void bt3() {  
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số phần tử của mảng: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[100];
        nhap(a, n);
        xuat(a, n);
        Console.ReadKey();
    }
}
