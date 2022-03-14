using System;
class Phan4BaiTap3 {
    static void nhap(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    
     static void xuat(int[] a, int n)
        {
            Console.Write("Hien thi mang:");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }
    
    public static void bt3() {  
        Console.Write("Nhap so ptu cua mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[100];
            nhap(a, n);
            xuat(a, n);

            Console.ReadKey();
    }
}
