using System;


static class Progarm
{
  static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = a + b;
        int d= a - b;
        int e = a * b;
        int g = a / b;
        int h = a % b;
        double j = Math.Pow(a, b);
        Console.WriteLine($"Kq cộng:{c} ");
        Console.WriteLine($"Kq trừ:{d} ");
        Console.WriteLine($"Kq nhân:{e} ");
        Console.WriteLine($"Kq chia lấy nguyên:{g} ");
        Console.WriteLine($"Kq chia lấy dư:{h} ");
        Console.WriteLine($"Kq lũy thừa:{j} ");

    }

}