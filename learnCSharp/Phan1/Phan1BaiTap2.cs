using System;
class Phan1BaiTap2 {
    public static void bt2() { 
        float toan, van, ly, hoa, sinh, anh, dtb;

        Console.WriteLine("Nhap diem toan: ");
        toan = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhap diem van: ");
        van = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhap diem ly: ");
        ly = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhap diem hoa: ");
        hoa = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhap diem sinh: ");
        sinh = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhap diem anh: ");
        anh = Convert.ToInt32(Console.ReadLine());

        dtb = (toan * 3 + (van + ly + anh) * 2 + hoa + sinh) / 11;
        Console.WriteLine("Diem trung binh: {0:0.00}", dtb);
    }
}

