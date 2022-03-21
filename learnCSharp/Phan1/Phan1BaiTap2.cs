using System;
using System.Text;

class Phan1BaiTap2 {
    public static void bt2() { 
        Console.OutputEncoding = Encoding.UTF8;
        double toan, van, ly, hoa, sinh, anh, dtb;

        Console.WriteLine("Nhập điểm toán: ");
        toan = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập điểm văn: ");
        van = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập điểm lý: ");
        ly = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập điểm hóa: ");
        hoa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập điểm sinh: ");
        sinh = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập điểm anh: ");
        anh = Convert.ToDouble(Console.ReadLine());

        dtb = (toan * 3 + (van + ly + anh) * 2 + hoa + sinh) / 11;
        Console.WriteLine("Điểm trung bình: {0:0.00}", dtb);
    }
}

