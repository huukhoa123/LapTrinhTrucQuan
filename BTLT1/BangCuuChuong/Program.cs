using System;

static class Program
{       
    static void Main()
    {
        int n;
        do
        { 
            Console.WriteLine("nhap so nguyen");
            n = int.Parse(Console.ReadLine());
            if(n < 0 || n > 9)
            {
                Console.WriteLine("nhap lai so nguyen tu 0 den 9");
            }
            else if(n >= 0 && n <= 9)
            {
                Console.WriteLine($"Bang cuu chuong cua {n}:");
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{n} x {i} = {n * i}");
                }
            }
        }
        while (n<0 || n> 9);
    }
}