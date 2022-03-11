using System;
class Phan3BaiTap1 {
    struct LUANVAN {
        public string maLuanVan;
        public string tenLuanVan; 
        public string tenSinhVien;
        public string tenGiangVien;
        public short namThucHien;

    }
    public static void bt1() {  
        LUANVAN LV;
        Console.Write("Nhap ma luan van: ");
        LV.maLuanVan = Console.ReadLine();
        while (LV.maLuanVan.Length > 10 && LV.maLuanVan.Length != null) {
            Console.Write("Nhap lai ma luan van: ");
        LV.maLuanVan = Console.ReadLine();
        }

        
    }
}