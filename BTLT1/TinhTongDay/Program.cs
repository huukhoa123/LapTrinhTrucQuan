using System;

namespace TinhTongDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Write("Nhap vao so nguyen duong n: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("=> Loi: n phai la so lon hon 0. Vui long nhap lai!\n");
                }
            }
            while (n <= 0);

            long tongToanBo = 0;
            long tongChan = 0;
            long tongLe = 0;
            long giaiThua = 1; 

            for (int i = 1; i <= n; i++)
            {
                tongToanBo += i; 

                if (i % 2 == 0)
                {
                    tongChan += i; 
                }
                else
                {
                    tongLe += i; 
                }
            }

           
            int j = 1;
            while (j <= n)
            {
                giaiThua *= j; 
                j++;           
            }
            Console.WriteLine($"\n========== KET QUA VOI n = {n} ==========");
            Console.WriteLine($"Tong tu 1 den {n}: \t\t{tongToanBo:N0}");
            Console.WriteLine($"Tong cac so chan: \t\t{tongChan:N0}");
            Console.WriteLine($"Tong cac so le: \t\t{tongLe:N0}");
            Console.WriteLine($"Tich (giai thua) cua {n}: \t{giaiThua:N0}");
            Console.WriteLine("=========================================");
        }
    }
}