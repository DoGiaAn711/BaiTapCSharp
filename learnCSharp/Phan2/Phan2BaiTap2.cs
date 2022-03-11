using System;
using System.Text;

class Phan2BaiTap2 {
    public static void bt2() {  
        Console.OutputEncoding = Encoding.UTF8; 
        Console.Write("Nhập tọa độ điểm A:\nAx = ");
        double Ax = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ay = ");
        double Ay = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Nhập tọa độ điểm B:\nBx = ");
        double Bx = Convert.ToDouble(Console.ReadLine());
        Console.Write("By = ");
        double By = Convert.ToDouble(Console.ReadLine());
        
        if ((Ax == Bx && Ay == By)) {
            Console.Write("2 điểm trùng nhau.");
        } else {
            Console.WriteLine("Tọa độ trung điểm C: C({0}; {1})", (Ax + Bx) / 2, (Ay + By) / 2);
            Console.WriteLine("Độ dài đoạn thẳng AB = {0:0.000}", (Math.Sqrt(Math.Pow(Math.Abs(Ax - Bx), 2) + Math.Pow(Math.Abs(Ay - By), 2))));
        }
    }
}