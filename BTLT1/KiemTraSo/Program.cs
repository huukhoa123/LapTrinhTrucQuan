using System;




static class Program
{
    static void Main(string[] args)
    {

        int a = int.Parse(Console.ReadLine());
        if (a > 0)
        {
            Console.WriteLine("day la so duong");
        }
        else if (a < 0)
        {
            Console.WriteLine("day la so am");
        }
        else
        {
            Console.WriteLine("day la so 0");
        }



        if (a % 2 == 0)
        {
            Console.WriteLine("day la so chan");
        }
        else
        {
            Console.WriteLine("day la so le");
        }
        if (a % 3 == 0)
        {
            Console.WriteLine("day la so chia het cho 3");
        }
        else
        {

            Console.WriteLine("day khong phai la so chia het cho 3");
        }
        if (a % 2 == 0 && a % 3 == 0)
        {
            Console.WriteLine("day la so chia het cho 2 va 3");
        }
        else
        {
            Console.WriteLine("day khong phai la so chia het cho 2 va 3");
        }
    }
}