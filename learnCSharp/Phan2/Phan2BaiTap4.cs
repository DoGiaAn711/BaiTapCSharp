using System;
using System.Text;

public class Phan2BaiTap4
{
    struct Toado
    {
        public double x, y;
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào y: ");
            y = double.Parse(Console.ReadLine());
        }
    }
    public static void bt4()
    {
        Toado A = new Toado();
        Toado B = new Toado();
        Console.WriteLine("Tọa độ điểm đầu: ");
        A.Nhap();
        Console.WriteLine("Tọa độ điểm cuối: ");
        B.Nhap();
        if (A.x == B.x && A.y == B.y)
        {
            Console.WriteLine("2 điểm trùng nhau. ");
        }
        else
        {
            Console.WriteLine("Trung điểm là M(" + Trungdiem(A.x, B.x) + ";" + Trungdiem(A.y, B.y) + ")");
            Console.WriteLine("Khoảng cách là: " + Khoangcach(A.x, B.x, A.y, B.y));
        }
    }
    public static double Trungdiem(double a, double b)
    {
        double trungdiem = (a + b) / 2;
        return trungdiem;
    }
    public static double Khoangcach(double a, double b, double c, double d)
    {
        double khoangcach = Math.Sqrt(Math.Pow(a - b, 2) + Math.Pow(c - d, 2));
        return khoangcach;
    }

}
