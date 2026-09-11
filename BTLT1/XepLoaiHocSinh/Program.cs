using System;

static class Program
{
    static void Main(string[] args)
    {
        float diem;
        do
        {
            Console.WriteLine("Nhập điểm trung bình của học sinh: ");
            diem = float.Parse(Console.ReadLine());
            if(diem < 0 || diem > 10)
            {
                Console.WriteLine("vui lòng nhập điểm trung bình từ 0 đến 10");
            }
            if (diem >= 9 && diem <= 10)
            {
                Console.WriteLine("Xuất sắc");
            }
            else if (diem >= 8 && diem < 9)
            {
                Console.WriteLine("Giỏi");
            }
            else if (diem >= 7 && diem < 8)
            {
                Console.WriteLine("Khá");
            }
            else if (diem >= 5 && diem < 7)
            {
                Console.WriteLine("Trung bình");
            }
            else if (diem >= 0 && diem < 5)
            {
                Console.WriteLine("Yếu");
            }
        }
        while (diem < 0 || diem > 10 );
      
    } 
}