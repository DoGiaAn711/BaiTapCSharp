using System;

public class Phan2Baitap4
{
    struct Toado
    {
        public double x, y;
        public void Nhap()
        {
            Console.WriteLine("Nhap vao x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao y");
            y = double.Parse(Console.ReadLine());
        }
        public void XuatX()
        {
            Console.WriteLine("X la : " + x);
        }
    }
    public static void Main(string[] args)
    {
        Toado A = new Toado();
        Toado B = new Toado();
        Console.WriteLine("Toa do diem dau: ");
        A.Nhap();
        Console.WriteLine("Toa do diem cuoi ");
        B.Nhap();
        if (A.x == B.x && A.y == B.y)
        {
            Console.WriteLine("2 diem trung nhau ");
        }
        else
        {
            Console.WriteLine("Trung diem la M(" + Trungdiem(A.x, B.x) + "," + Trungdiem(A.y, B.y) + ")");
            Console.WriteLine("Khoang cach la: " + Khoangcach(A.x, B.x, A.y, B.y));
        }
    }
    public static double Trungdiem(double a, double b)
    {
        double trungdiem = (a - b) / 2;
        return trungdiem;
    }
    public static double Khoangcach(double a, double b, double c, double d)
    {
        double khoangcach = Math.Sqrt(Math.Pow(a - b, 2) + Math.Pow(c - d, 2));
        return khoangcach;
    }

}
