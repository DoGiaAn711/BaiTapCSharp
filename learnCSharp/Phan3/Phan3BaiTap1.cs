using System;
class Phan3BaiTap1 {
    public struct LUANVAN {
        public string maLuanVan;
        public string tenLuanVan; 
        public string tenSinhVien;
        public string tenGiangVien;
        public short namThucHien;

    }    
    public static void output(LUANVAN LV) {
        Console.WriteLine("\n-----THONG TIN LUAN VAN-----");
        Console.WriteLine("Ma luan van: \t" + LV.maLuanVan);
        Console.WriteLine("Ten luan van: \t" + LV.tenLuanVan);
        Console.WriteLine("Ten sinh vien: \t" + LV.tenSinhVien);
        Console.WriteLine("Ten giang vien: " + LV.tenGiangVien);
        Console.WriteLine("Nam thuc hien: \t" + LV.namThucHien);
    }
    public static void input(LUANVAN LV) {
        Console.Write("Nhap ma luan van: ");
        LV.maLuanVan = Console.ReadLine();
        while (LV.maLuanVan.Length > 11) {
            Console.Write("Nhap lai ma luan van: ");
            LV.maLuanVan = Console.ReadLine();
        }

        Console.Write("Nhap ten luan van: ");
        LV.tenLuanVan = Console.ReadLine();

        Console.Write("Nhap ten sinh vien: ");
        LV.tenSinhVien = Console.ReadLine();

        Console.Write("Nhap ten giang vien: ");
        LV.tenGiangVien = Console.ReadLine();

        Console.Write("Nhap nam thuc hien: ");
        LV.namThucHien = short.Parse(Console.ReadLine());
        while (LV.namThucHien > 2022) {
            Console.Write("Nhap lai nam thuc hien: ");
            LV.namThucHien = short.Parse(Console.ReadLine());
        }
        output(LV);
    }
    public static void bt1() {  
        LUANVAN LV = new LUANVAN();
        input(LV);
    }
}