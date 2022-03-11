using System;
class Phan3BaiTap1 {
    struct LUANVAN {
        public string maLuanVan;
        public string tenLuanVan; 
        public string tenSinhVien;
        public string tenGiangVien;
        public short namThucHien;

    }
    public static void output(string maLuanVan, string tenLuanVan, string tenSinhVien, string tenGiangVien, short namThucHien) {
        Console.WriteLine("\n-----THONG TIN LUAN VAN-----");
        Console.WriteLine("Ma luan van: \t" + maLuanVan);
        Console.WriteLine("Ten luan van: \t" + tenLuanVan);
        Console.WriteLine("Ten sinh vien: \t" + tenSinhVien);
        Console.WriteLine("Ten giang vien: " + tenGiangVien);
        Console.WriteLine("Nam thuc hien: \t" + namThucHien);
    }
    public static void bt1() {  
        LUANVAN LV = new LUANVAN();
        Console.Write("Nhap ma luan van: ");
        LV.maLuanVan = Console.ReadLine();
        while (LV.maLuanVan.Length > 10) {
            Console.Write("Nhap lai ma luan van: ");
            LV.maLuanVan = Console.ReadLine();
        }

        Console.Write("Nhap ten luan van: ");
        LV.tenLuanVan = Console.ReadLine();
        while (LV.tenLuanVan.Length > 100) {
            Console.Write("Nhap lai ten luan van: ");
            LV.tenLuanVan = Console.ReadLine();
        }

        Console.Write("Nhap ten sinh vien: ");
        LV.tenSinhVien = Console.ReadLine();
        while (LV.tenSinhVien.Length > 30) {
            Console.Write("Nhap lai ten sinh vien: ");
            LV.tenSinhVien = Console.ReadLine();
        }

        Console.Write("Nhap ten giang vien: ");
        LV.tenGiangVien = Console.ReadLine();
        while (LV.tenGiangVien.Length > 30) {
            Console.Write("Nhap lai ten giang vien: ");
            LV.tenGiangVien = Console.ReadLine();
        }

        Console.Write("Nhap nam thuc hien: ");
        LV.namThucHien = short.Parse(Console.ReadLine());
        while (LV.namThucHien > 2022) {
            Console.Write("Nhap lai nam thuc hien: ");
            LV.namThucHien = short.Parse(Console.ReadLine());
        }

        output(LV.maLuanVan, LV.tenLuanVan, LV.tenSinhVien, LV.tenGiangVien, LV.namThucHien);
    }
}