using System;
using System.Text;

class Phan4BaiTap1 {
    public static int Count(int[] arr) {
        int cnt = 0;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] < 100) {
                cnt++;
            }
        }
        return cnt;
    }
    public static void bt1() {  
        Console.OutputEncoding = Encoding.UTF8; 
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++) {
            Console.Write("Nhập phần tử thứ {0}: ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Số các số nhỏ hơn 100: " + Count(arr));
    }
}