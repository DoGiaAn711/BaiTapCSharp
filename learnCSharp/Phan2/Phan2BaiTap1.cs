using System;
class Phan2BaiTap1 {
    public static void bt1() {  
        Console.Write("Nhap gia tri cua a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap gia tri cua b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap gia tri cua c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a) {
            Console.WriteLine("Day la 3 canh cua mot tam giac");
            Console.WriteLine("Chu vi tam giac = " + (a + b + c));
            Console.WriteLine("Dien tich tam giac = {0:0.000}", (Math.Sqrt((a + b + c) * (a + b - c) * (b + c - a) * (c + a - b)) / 4));
        } else Console.WriteLine("Day khong la 3 canh cua mot tam giac");
    }
}