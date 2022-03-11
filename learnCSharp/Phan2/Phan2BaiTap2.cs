using System;
class Phan2BaiTap2 {
    public static void bt2() {  
        Console.Write("Nhap toa do diem A:\nx = ");
        double Ax = Convert.ToDouble(Console.ReadLine());
        Console.Write("y = ");
        double Ay = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Nhap toa do diem B:\nx = ");
        double Bx = Convert.ToDouble(Console.ReadLine());
        Console.Write("y = ");
        double By = Convert.ToDouble(Console.ReadLine());
        
        if (Ax == Bx && Ay == By) {
            Console.Write("2 diem trung nhau");
        } else {
            Console.WriteLine("Toa do trung diem C: C({0}; {1})", (Ax + Bx) / 2, (Ay + By) / 2);
            Console.WriteLine("Do dai doan thang = {0:0.000}", (Math.Sqrt(Math.Pow(Math.Abs(Ax - Bx), 2) + Math.Pow(Math.Abs(Ay - By), 2))));
        }
    }
}