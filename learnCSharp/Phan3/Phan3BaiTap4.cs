using System;
using System.Text;

class Phan3BaiTap4 {
    //Cách 1: sử dụng đệ quy
    public static int cnt = 0;
    public static int count1(int n) {
        if (n < 10) {
            return ++cnt;
        } else {
            cnt++;
            return count1(n / 10); 
        }
    }

    //Cách 2: sử dụng chuỗi
    public static int count2(int n) {
        string n1 = n.ToString();
        return n1.Length;
    }
    public static void bt4() {  
        Console.OutputEncoding = Encoding.UTF8; 
        Console.Write("Nhập số nguyên n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Cách 1:\nSố nguyên n có {0} chữ số", count1(n));
        Console.Write("Cách 2:\nSố nguyên n có {0} chữ số", count2(n));
    }
}