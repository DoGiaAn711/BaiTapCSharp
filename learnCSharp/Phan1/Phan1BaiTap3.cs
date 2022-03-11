using System;
class Phan1BaiTap3 {
    public static double CauA(double x) {
        return 2 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) + 7 * x + 15;
    }
    public static double CauB(double x) {
        return Math.Pow(Math.Sin(x), 2) + Math.Pow(Math.Cos(2 * x), 2) + Math.Pow(Math.Tan(3 * x), 2);
    }
    public static double CauC(double x) {
        return Math.Pow((x + 10), (x + 5));
    }
    public static double CauD(double x) {
        return 3 * Math.Pow(Math.E, Math.Cos(x + 1));
    }
    public static double CauE(double x) {
        return Math.Log10(x + 100);
    }
    public static void bt3() {  
        Console.Write("Nhap gia tri cua x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("y1 = " + CauA(x));
        Console.WriteLine("y2 = " + CauB(x));
        Console.WriteLine("y3 = " + CauC(x));
        Console.WriteLine("y4 = " + CauD(x));
        Console.WriteLine("y5 = " + CauE(x));
        
    }
}