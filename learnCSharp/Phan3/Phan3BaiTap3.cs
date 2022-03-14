using System;
<<<<<<< Updated upstream
class Phan3BaiTap3 {
    public static void bt3() {  
        Console.WriteLine("\"Chào bạn!\"");
        Console.WriteLine("\"Tôi tên là: Nguyen Van A\"");
        Console.WriteLine("\"MSSV là: D12CQCN01-N\"");
    }
}
=======
    class Phan3BaiTap3 {
        public static void bt3() {
            int n = Convert.ToInt32(Console.ReadLine());
            double a=Math.Sqrt(n);
            double b=Math.Floor(a);
            if (a==b){
                Console.WriteLine("true");
            } else {
                Console.WriteLine("false");
            }
            for (int i = 0; i<=Math.Sqrt(1000);i++){
                Console.WriteLine(i*i);
            }
        }
    }

>>>>>>> Stashed changes
