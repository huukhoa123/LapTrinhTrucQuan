using System;

namespace QuanLySachCoBan
{
    public class Sach
    {
        // Private fields
        private string _maSach;
        private string _tenSach;
        private string _tacGia;
        private int _namXuatBan;
        private double _giaBan;

        // Static counter to generate default MaSach values
        private static int _counter = 1;

        // Full-parameter constructor
        public Sach(string maSach, string tenSach, string tacGia, int namXuatBan, double giaBan)
        {
            _maSach = maSach ?? throw new ArgumentNullException(nameof(maSach));
            TenSach = tenSach; // use property to validate
            TacGia = tacGia;
            NamXuatBan = namXuatBan; // use property to validate
            _giaBan = giaBan;
        }

        // Parameterless constructor with reasonable defaults
        public Sach()
        {
            _maSach = GenerateMaSach();
            _tenSach = "Chua xac dinh";
            _tacGia = "Khong ro";
            _namXuatBan = DateTime.Now.Year;
            _giaBan = 0.0;
        }

        // Properties
        public string MaSach => _maSach; // read-only

        public string TenSach
        {
            get => _tenSach;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("TenSach khong duoc rong.", nameof(TenSach));
                _tenSach = value.Trim();
            }
        }

        public string TacGia
        {
            get => _tacGia;
            set => _tacGia = value ?? string.Empty;
        }

        public int NamXuatBan
        {
            get => _namXuatBan;
            set
            {
                int year = DateTime.Now.Year;
                if (value < 1900 || value > year)
                    throw new ArgumentOutOfRangeException(nameof(NamXuatBan), $"NamXuatBan phai nam trong khoang 1900..{year}.");
                _namXuatBan = value;
            }
        }

        public double GiaBan => _giaBan; // read-only from outside

        // Display method
        public void HienThiThongTin()
        {
            Console.WriteLine("NGUYEN HUU KHOA 6551071049")
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Ma sach     : {MaSach}");
            Console.WriteLine($"Ten sach    : {TenSach}");
            Console.WriteLine($"Tac gia     : {TacGia}");
            Console.WriteLine($"Nam xuat ban: {NamXuatBan}");
            Console.WriteLine($"Gia ban     : {GiaBan:C}");
            Console.WriteLine("----------------------------------------\n");
        }

        // Override ToString()
        public override string ToString()
        {
            return $"{MaSach} - {TenSach} by {TacGia} ({NamXuatBan}) - {GiaBan:C}";
        }

        private static string GenerateMaSach()
        {
            return $"S{_counter++.ToString("D3")}";
        }
    }
}
