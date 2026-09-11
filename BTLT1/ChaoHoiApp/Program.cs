using System;

static class Program
{
    static void Main(string[] args)
    {

        string hoTen = Console.ReadLine();
        int Tuoi = int.Parse(Console.ReadLine());
        double chieuCao = double.Parse(Console.ReadLine());
        float canNang = float.Parse(Console.ReadLine());
        bool daTotNghiep = true;


        Console.WriteLine($"Họ và Tên: {hoTen}");
        Console.WriteLine($"Tuổi : {Tuoi}");
        Console.WriteLine($"Chiều Cao: {chieuCao}");
        Console.WriteLine($"Cân nặng: {canNang}");
        Console.WriteLine($"Đã tốt nghiệp {daTotNghiep}");
    }
}

