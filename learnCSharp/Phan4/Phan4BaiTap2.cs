using System;
using System.Text;

class Phan4BaiTap2 {
    public static double _sum (double[] arr) {
        double negativeSum = 0;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] < 0) {
                negativeSum += arr[i];
            }
        }
        return negativeSum;
    } 
    public static void bt2() {  
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số phần tử của mảng: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] arr = new double[n];
        for (int i = 0; i < n; i++) {
            Console.Write("arr[" + i + "] = ");
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.Write("Tổng các số âm trong mảng: {0}", _sum(arr));        
    }
}