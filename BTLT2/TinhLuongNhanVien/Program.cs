using System;

namespace LuongNhanVien
{
    public class NhanVien
    {
        private string _maNhanVien;
        private string _hoTen;
        private decimal _luongCoBan;
        private int _soNgayLam;
        private int _soNgayNghiPhep;

        //hàm đầy đủ tham số
        public NhanVien(string maNhanVien, string hoTen, decimal luongCoBan, int soNgayLam, int soNgayNghiPhep)
        {
            _maNhanVien = maNhanVien;
            _hoTen = hoTen;
            _luongCoBan = luongCoBan;
            _soNgayLam = soNgayLam;
            _soNgayNghiPhep = soNgayNghiPhep;
        }
        // hàm không tham số
        public NhanVien()
        {
            _maNhanVien = "Chua co";
            _hoTen = "Chua xac dinh";
            _luongCoBan = 0.0m;
            _soNgayLam = 0;
            _soNgayNghiPhep = 0;
        }
        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        public decimal LuongCoBan
        {
            get { return _luongCoBan; }
            set
            {
                if (value >= 0)
                    _luongCoBan = value;
                else
                    Console.WriteLine("Luong co ban ko hop le!");
            }

        }
        public int SoNgayLam
        {
            get { return _soNgayLam; }
            set
            {
                if (value >= 0 && value <= 31)
                    _soNgayLam = value;
                else
                    Console.WriteLine("Số ngày làm phải từ 0 đến 31!");
            }
        }
        public decimal LuongThucNhan
        {
            get
            {
                decimal khauTruBHXH = 0.08m * LuongCoBan;
                return (LuongCoBan / 26 * SoNgayLam) - khauTruBHXH;
            }
        }
        // Constructor Optional Parameters
        public NhanVien(string maNhanVien, string hoTen, decimal luong = 5_000_000m, int soNgayLam = 26)
        {
            _maNhanVien = maNhanVien;
            HoTen = hoTen;
            LuongCoBan = luong;
            SoNgayLam = soNgayLam;
            _soNgayNghiPhep = 0;
        }
        public decimal TinhThuong()
        {
            return 0;
        }

        public decimal TinhThuong(decimal heSo)
        {
            return LuongCoBan * heSo;
        }

        public decimal TinhThuong(decimal heSo, bool coPhucLoi)
        {
            decimal tienThuong = LuongCoBan * heSo;
            if (coPhucLoi == true)
            {
                tienThuong = tienThuong + 500_000m;
            }
            return tienThuong;
        }

        // Phương thức hỗ trợ in thông tin để dễ kiểm tra
        public void HienThiThongTin()
        {
            Console.WriteLine($"Mã NV: {_maNhanVien} | Họ tên: {HoTen} | Lương cơ bản: {LuongCoBan:N0}đ | Ngày làm: {SoNgayLam} | Thực nhận: {LuongThucNhan:N0}đ");
        }
        class Program
        {
            static void Main(string[] args)
            {
                
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("NGUYEN HUU KHOA 6551071049 \n");
                Console.WriteLine("--- DANH SÁCH NHÂN VIÊN ---");

               
                NhanVien nv1 = new NhanVien();
                nv1.HoTen = "Nguyễn Văn A";
                nv1.LuongCoBan = 6_000_000m;
                nv1.SoNgayLam = 24;
                nv1.HienThiThongTin();

                
                NhanVien nv2 = new NhanVien("NV002", "Trần Thị B", 8_000_000m, 26, 2);
                nv2.HienThiThongTin();

                
                NhanVien nv3 = new NhanVien(maNhanVien: "NV003", hoTen: "Lê Văn C", soNgayLam: 20);
                nv3.HienThiThongTin();

                Console.WriteLine("\n--- SO SÁNH TÍNH THƯỞNG (Áp dụng cho NV002) ---");

            
                decimal thuong1 = nv2.TinhThuong();
                decimal thuong2 = nv2.TinhThuong(1.5m);
                decimal thuong3 = nv2.TinhThuong(1.5m, true);

                Console.WriteLine($"- Không có hệ số: {thuong1:N0}đ");
                Console.WriteLine($"- Hệ số 1.5, không phúc lợi: {thuong2:N0}đ");
                Console.WriteLine($"- Hệ số 1.5, có phúc lợi (+500k): {thuong3:N0}đ");

                Console.ReadLine();
            }
        }
    }
}

