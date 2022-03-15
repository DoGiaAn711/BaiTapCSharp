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
    public static void output(ref LUANVAN LV) {
        Console.WriteLine("\n-----THÔNG TIN LUẬN VĂN-----");
        Console.WriteLine("Mã luận văn: \t" + LV.maLuanVan);
        Console.WriteLine("Tên luận văn: \t" + LV.tenLuanVan);
        Console.WriteLine("Tên sinh viên: \t" + LV.tenSinhVien);
        Console.WriteLine("Tên giảng viên: " + LV.tenGiangVien);
        Console.WriteLine("Năm thực hiện: \t" + LV.namThucHien);
    }
    
    public static void nhap(ref string str1, int n, string str2) {
        Console.Write("Nhập {0}: ", str2);
        str1 = Console.ReadLine();
        while (str1.Length > n) {
            Console.Write("Nhập lại mã luận văn: ");
            str1 = Console.ReadLine();
        }
    }
    public static void input(ref LUANVAN LV) {
        nhap(ref LV.maLuanVan, 10, "mã luận văn");

        nhap(ref LV.tenLuanVan, 100, "tên luận văn");
        
        nhap(ref LV.tenSinhVien, 30, "tên sinh viên");
        
        nhap(ref LV.tenGiangVien, 30, "tên giảng viên");

        Console.Write("Nhập năm thực hiện: ");
        LV.namThucHien = short.Parse(Console.ReadLine());
        while (LV.namThucHien > 2022 || LV.namThucHien < 1900) {
            Console.Write("Nhập lại năm thực hiện: ");
            LV.namThucHien = short.Parse(Console.ReadLine());
        }
        
    }
    public static void bt1() {  
        Console.OutputEncoding = Encoding.UTF8; 
        LUANVAN LV = new LUANVAN();
        input(ref LV);
        output(ref LV);
    }
}