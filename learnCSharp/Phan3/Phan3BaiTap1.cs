using System;
using System.Text;

class Phan3BaiTap1 {
    public struct LUANVAN {
        public string maLuanVan;
        public string tenLuanVan; 
        public string tenSinhVien;
        public string tenGiangVien;
        public short namThucHien;

    }    
    public static void output(LUANVAN LV) {
        Console.WriteLine("\n-----THÔNG TIN LUẬN VĂN-----");
        Console.WriteLine("Mã luận văn: \t" + LV.maLuanVan);
        Console.WriteLine("Tên luận văn: \t" + LV.tenLuanVan);
        Console.WriteLine("Tên sinh viên: \t" + LV.tenSinhVien);
        Console.WriteLine("Tên giảng viên: " + LV.tenGiangVien);
        Console.WriteLine("Năm thực hiện: \t" + LV.namThucHien);
    }
    
    public static void input(LUANVAN LV) {
        Console.Write("Nhập mã luận văn: ");
        LV.maLuanVan = Console.ReadLine();
        while (LV.maLuanVan.Length > 10) {
            Console.Write("Nhập lại mã luận văn: ");
            LV.maLuanVan = Console.ReadLine();
        }

        Console.Write("Nhập tên luận văn: ");
        LV.tenLuanVan = Console.ReadLine();
        while (LV.tenLuanVan.Length > 100) {
            Console.Write("Nhập lại tên luận văn: ");
            LV.tenLuanVan = Console.ReadLine();
        }

        Console.Write("Nhập tên sinh viên: ");
        LV.tenSinhVien = Console.ReadLine();
        while (LV.tenSinhVien.Length > 30) {
            Console.Write("Nhập lại tên sinh viên: ");
            LV.tenSinhVien = Console.ReadLine();
        }

        Console.Write("Nhập tên giảng viên: ");
        LV.tenGiangVien = Console.ReadLine();
        while (LV.tenGiangVien.Length > 30) {
            Console.Write("Nhập lại tên giảng viên: ");
            LV.tenGiangVien = Console.ReadLine();
        }

        Console.Write("Nhập năm thực hiện: ");
        LV.namThucHien = short.Parse(Console.ReadLine());
        while (LV.namThucHien > 2022) {
            Console.Write("Nhập lại năm thực hiện: ");
            LV.namThucHien = short.Parse(Console.ReadLine());
        }
        output(LV);
    }
    public static void bt1() {  
        Console.OutputEncoding = Encoding.UTF8; 
        LUANVAN LV = new LUANVAN();
        input(LV);
    }
}