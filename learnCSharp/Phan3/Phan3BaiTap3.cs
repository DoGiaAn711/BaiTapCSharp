using System;
namespace CSharp {
    class Phan3BaiTap4 {
        public static void Main(string[] args) {
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
}
