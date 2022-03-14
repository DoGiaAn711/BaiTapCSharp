using System;
using System.Text;

class Phan3BaiTap3 {
    public static void bt3() {  
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số cần kiểm tra: ");
        int n = Convert.ToInt32(Console.ReadLine());
            double a = Math.Sqrt(n);
            double b = Math.Floor(a);
            if (a == b){
                Console.WriteLine("Đây là số chính phương!");
            } else {
                Console.WriteLine("Đây không phải số chính phương!");
            }
            
            Console.WriteLine("Các số chính phương <= 1000: ");
            for (int i = 0; i <= Math.Sqrt(1000); i++){
                Console.Write(i * i + " ");
            }
    }
}