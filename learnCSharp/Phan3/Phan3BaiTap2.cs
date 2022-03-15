using System;
using System.Text;

class Phan3BaiTap2 {
    public struct NGAY {
        public int ngay, thang, nam;
    }
    public struct HOPSUA {
        public string NhanHieu;
	    public double TrongLuong;
	    public NGAY HanSuDung;
    }
    public static bool CheckNamNhuan(NGAY Ngay) {
	return ((Ngay.nam % 4) == 0 && (Ngay.nam % 100) != 0) || ((Ngay.nam % 400) == 0);
    }
    public static int TimSoNgayTrongThang (NGAY Ngay) {
        int NgayTrongThang = 0;
	switch(Ngay.thang) {
    	case 1: case 3: case 5: case 7: case 8: case 10: case 12:
	    	NgayTrongThang = 31;
    		break;
    	case 4: case 6: case 9 : case 11:
	    	NgayTrongThang = 30;
		    break;
    	case 2: {
            int Check = Convert.ToInt32(CheckNamNhuan(Ngay));
		    if(Check == 1) {
			    NgayTrongThang = 29;
		    }
		    else {
			    NgayTrongThang = 28;
		    }
            break;
        }		
	}
	return NgayTrongThang;
    }
    public static void NhapNgay(ref NGAY Ngay) {
        Console.Write("Nhập năm: ");
        Ngay.nam = Convert.ToInt32(Console.ReadLine());
        while(Ngay.nam < 1900 || Ngay.nam > 2050) {
            Console.Write("Nhập lại năm: ");
            Ngay.nam = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.Write("Nhập tháng: ");
        Ngay.thang = Convert.ToInt32(Console.ReadLine());
        while(Ngay.thang < 1 || Ngay.thang > 12) {
            Console.Write("Nhập lại tháng: ");
            Ngay.thang = Convert.ToInt32(Console.ReadLine());
        }

        int NgayTrongThang = TimSoNgayTrongThang(Ngay);
        Console.Write("Nhập ngày: ");
        Ngay.ngay = Convert.ToInt32(Console.ReadLine());
        while(Ngay.ngay < 1 || Ngay.ngay > NgayTrongThang) {
            Console.Write("Nhập lại ngày: ");
            Ngay.ngay = Convert.ToInt32(Console.ReadLine());
        }
    }
    public static void XuatNgay(ref NGAY Ngay) {
        Console.Write(Ngay.ngay + "/" + Ngay.thang + "/" + Ngay.nam);
    }
    public static void NhapHopSua(ref HOPSUA hs) {
        Console.Write("Nhập nhãn hiệu: ");
        hs.NhanHieu = Console.ReadLine();
        while(hs.NhanHieu.Length > 20) {
            Console.Write("Nhập lại nhãn hiệu: ");
            hs.NhanHieu = Console.ReadLine();
        }

        Console.Write("Nhập trọng lượng: ");
        hs.TrongLuong = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập hạn sử dụng: \n");
        NhapNgay(ref hs.HanSuDung);
    }
    static void XuatHopSua(ref HOPSUA hs) {
        Console.WriteLine("\n---THÔNG TIN HỘP SỮA---");
        Console.WriteLine("Nhãn hiệu: \t" + hs.NhanHieu);
        Console.WriteLine("Trọng lượng: \t" + hs.TrongLuong);
        Console.Write("Hạn sử dụng: \t");
        XuatNgay(ref hs.HanSuDung);
    }
    public static void bt2() {
        Console.OutputEncoding = Encoding.UTF8; 
        HOPSUA hs = new HOPSUA();
        NhapHopSua(ref hs);
	    XuatHopSua(ref hs);
    }
}