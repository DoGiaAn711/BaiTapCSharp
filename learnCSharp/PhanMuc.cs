using System;
class PhanMuc {
    public static void PM() {  
        Console.Write("Nhap phan bai tap muon lam: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap bai muon lam: ");
        int m = Convert.ToInt32(Console.ReadLine());
        switch (n) {
            case 1: {
                switch (m) {
                    case 1: {
                        Phan1BaiTap1.bt1();
                        break;
                    } 
                    case 2: {
                        learnCSharp.Phan1BaiTap2.bt2();
                        break;
                    }
                    case 3: {
                        Phan1BaiTap3.bt3();
                        break;
                    }
                }
                break;
            }
            case 2: {
                switch (m) {
                    case 1: {
                        Phan2BaiTap1.bt1();
                        break;
                } 
                    case 2: {
                        Phan2BaiTap2.bt2();
                        break;
                    }
                    case 3: {
                        Phan2BaiTap3.bt3();
                        break;
                    }
                    case 4: {
                        Phan2BaiTap4.bt4();
                        break;
                    }
                }
                break;
            }
            case 3: {
                switch (m) {
                    case 1: {
                        Phan3BaiTap1.bt1();
                        break;
                } 
                    case 2: {
                        Phan3BaiTap2.bt2();
                        break;
                    }
                    case 3: {
                        Phan3BaiTap3.bt3();
                        break;
                    }
                    case 4: {
                        Phan3BaiTap4.bt4();
                        break;
                    }
                }
                break;
            }
            case 4: {
                switch (m) {
                    case 1: {
                        Phan4BaiTap1.bt1();
                        break;
                    } 
                    case 2: {
                        Phan4BaiTap2.bt2();
                        break;
                    }
                    case 3: {
                        Phan4BaiTap3.bt3();
                        break;
                    }
                }
                break;
            }
        }
    }
}