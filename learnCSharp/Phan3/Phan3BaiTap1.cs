using System;
using System.Text;

class Phan3BaiTap1 {
    public struct LUANVAN {
        public char[] maLuanVan;
        public char[] tenLuanVan; 
        public char[] tenSinhVien;
        public char[] tenGiangVien;
        public short namThucHien;

    }    
    public static void output(LUANVAN LV) {
        Console.OutputEncoding = Encoding.UTF8; 
        Console.WriteLine("\n-----THÔNG TIN LUẬN VĂN-----");
        Console.WriteLine("Mã luận văn: \t" + LV.maLuanVan);
        Console.WriteLine("Tên luận văn: \t" + LV.tenLuanVan);
        Console.WriteLine("Tên sinh viên: \t" + LV.tenSinhVien);
        Console.WriteLine("Tên giảng viên: " + LV.tenGiangVien);
        Console.WriteLine("Năm thực hiện: \t" + LV.namThucHien);
    }

    public static void readLine(char[] chr, int n, string str) {
        Console.Write("Nhập " + str + ": ");
        chr = Console.ReadLine().ToCharArray();
        while (chr[0] == '\n' || chr.Length > n) {
            Console.Write("Nhập lại " + str + ": ");
            chr = Console.ReadLine().ToCharArray();
        }
        
    }
    public static void input(LUANVAN LV) {
        Console.OutputEncoding = Encoding.UTF8; 
        
        readLine(LV.maLuanVan, 10, "mã luận văn");
        
        readLine(LV.tenLuanVan, 100, "tên luận văn");

        readLine(LV.tenSinhVien, 30, "tên sinh viên");

        readLine(LV.tenGiangVien, 30, "tên giảng viên");

        Console.Write("Nhập năm thực hiện: ");
        LV.namThucHien = Convert.ToInt16(Console.ReadLine());
        while (LV.namThucHien > 2022) {
            Console.Write("Nhập lại năm thực hiện: ");
            LV.namThucHien = Convert.ToInt16(Console.ReadLine());
        }
        output(LV);
    }
    public static void bt1() {  
        LUANVAN LV = new LUANVAN();
        input(LV);
    }
}