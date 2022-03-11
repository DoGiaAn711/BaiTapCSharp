using System;
using System.Text;

class PhanMuc {
    public static void PM() {  
        Console.OutputEncoding = Encoding.UTF8; 
        Console.Write("Nhập phần bài tập muốn làm: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập bài tập muốn làm: ");
        int m = Convert.ToInt32(Console.ReadLine());
        switch (n) {
            case 1: {
                switch (m) {
                    case 1: {
                        Console.WriteLine("\n---PHẦN 1 BÀI 1---");
                        Phan1BaiTap1.bt1();
                        break;
                    } 
                    case 2: {
                        Console.WriteLine("\n---PHẦN 1 BÀI 2---");
                        Phan1BaiTap2.bt2();
                        break;
                    }
                    case 3: {
                        Console.WriteLine("\n---PHẦN 1 BÀI 3---");
                        Phan1BaiTap3.bt3();
                        break;
                    }
                    default: {
                        Console.WriteLine("NHẬP SAI BÀI TẬP!");
                        break;
                    }
                }
                break;
            }
            case 2: {
                switch (m) {
                    case 1: {
                        Console.WriteLine("\n---PHẦN 2 BÀI 1---");
                        Phan2BaiTap1.bt1();
                        break;
                } 
                    case 2: {
                        Console.WriteLine("\n---PHẦN 2 BÀI 2---");
                        Phan2BaiTap2.bt2();
                        break;
                    }
                    case 3: {
                        Console.WriteLine("\n---PHẦN 2 BÀI 3---");
                        Phan2BaiTap3.bt3();
                        break;
                    }
                    case 4: {
                        Console.WriteLine("\n---PHẦN 2 BÀI 4---");
                        Phan2BaiTap4.bt4();
                        break;
                    }
                    default: {
                        Console.WriteLine("NHẬP SAI BÀI TẬP!");
                        break;
                    }
                }
                break;
            }
            case 3: {
                switch (m) {
                    case 1: {
                        Console.WriteLine("\n---PHẦN 3 BÀI 1---");
                        Phan3BaiTap1.bt1();
                        break;
                } 
                    case 2: {
                        Console.WriteLine("\n---PHẦN 3 BÀI 2---");
                        Phan3BaiTap2.bt2();
                        break;
                    }
                    case 3: {
                        Console.WriteLine("\n---PHẦN 3 BÀI 3---");
                        Phan3BaiTap3.bt3();
                        break;
                    }
                    case 4: {
                        Console.WriteLine("\n---PHẦN 3 BÀI 4---");
                        Phan3BaiTap4.bt4();
                        break;
                    }
                    default: {
                        Console.WriteLine("NHẬP SAI BÀI TẬP!");
                        break;
                    }
                }
                break;
            }
            case 4: {
                switch (m) {
                    case 1: {
                        Console.WriteLine("\n---PHẦN 4 BÀI 1---");
                        Phan4BaiTap1.bt1();
                        break;
                    } 
                    case 2: {
                        Console.WriteLine("\n---PHẦN 4 BÀI 2---");
                        Phan4BaiTap2.bt2();
                        break;
                    }
                    case 3: {
                        Console.WriteLine("\n---PHẦN 4 BÀI 3---");
                        Phan4BaiTap3.bt3();
                        break;
                    }
                    default: {
                        Console.WriteLine("NHẬP SAI BÀI TẬP!");
                        break;
                    }
                }
                break;
            }
            default: {
                        Console.WriteLine("NHẬP SAI PHẦN BÀI TẬP!");
                        break;
                    }
        }
    }
}