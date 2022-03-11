using System;
using System.Text;

class Phan2BaiTap1 {
    public static void bt1() {  
        Console.OutputEncoding = Encoding.UTF8; 
        Console.Write("Nhập giá trị của a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập giá trị của b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập giá trị của c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a) {
            Console.WriteLine("Đây là 3 cạnh của một tam giác.");
            Console.WriteLine("Chu vi tam giác = " + (a + b + c));
            Console.WriteLine("Diện tích tam giác = {0:0.000}", (Math.Sqrt((a + b + c) * (a + b - c) * (b + c - a) * (c + a - b)) / 4));
        } else Console.WriteLine("Đây không là 3 cạnh của một tam giác.");
    }
}