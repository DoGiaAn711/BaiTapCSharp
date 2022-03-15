using System;

namespace Phan3Baitap2
{
    internal class Program
    {
        struct NGAY
        {
            public string ngay;
            public void nhapNGAY()
            {
                Console.WriteLine("Nhap han su dung: ");
                ngay = Console.ReadLine();
                // Một tháng có tối đa 31 ngày
                while(ngay[0]-48 > 3)
                {
                    Console.WriteLine("Nhap lai");
                    ngay = Console.ReadLine();
                }
                while(ngay[0]-48 == 3 && ngay[1]-48 > 1)
                {
                    Console.WriteLine("Nhap lai");
                    ngay = Console.ReadLine();
                }
                // Một năm có 12 tháng
                while (ngay[2]-48 > 1)
                {
                    Console.WriteLine("Nhap lai");
                    ngay = Console.ReadLine();
                }
                while(ngay[2]-48 == 1 && ngay[3]-48 > 2)
                {
                    Console.WriteLine("Nhap lai");
                    ngay = Console.ReadLine();
                }
                // Ngày tháng năm có tối đa 8 chữ số
                while(ngay.Length > 8)
                {
                    Console.WriteLine("Nhap lai");
                    ngay = Console.ReadLine();
                }    
            }

        }
        struct HOPSUA
        {
            public string nhanhieu;
            public double trongluong;
            public NGAY hansudung;
            public void NHAP()
            {
                Console.WriteLine("--Nhap thong tin hop sua--");
                Console.WriteLine("Nhap nhan hieu: ");
                nhanhieu = Console.ReadLine();
              
                while(nhanhieu.Length > 10)
                {
                    Console.WriteLine("Nhap lai: ");
                    nhanhieu = Console.ReadLine();
                }
                Console.WriteLine("Nhap trong luong: ");
                trongluong = double.Parse(Console.ReadLine());
                hansudung.nhapNGAY();

            }
            public void XUAT()
            {
                Console.WriteLine("Nhan hieu: " + nhanhieu);
                Console.WriteLine("Trong luong: " + trongluong);
                Console.WriteLine("Han su dung: " + hansudung.ngay);
            }
        } 
        static void Main(string[] args)
        {
            HOPSUA vinamilk;
            vinamilk = new HOPSUA();
            vinamilk.NHAP();
            vinamilk.XUAT();
        }
    }
}
