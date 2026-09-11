using System;
using System.Collections.Generic;

namespace QuanLySanPhamCuaHang
{
    // ==========================================
    // 1. CLASS CƠ SỞ (BASE CLASS)
    // ==========================================
    class SanPham
    {
        // Khai báo field private
        private string _maSP;
        private string _tenSP;
        private decimal _gia;
        private int _soLuongTon;

        // Khai báo Property
        public string MaSP { get { return _maSP; } set { _maSP = value; } }
        public string TenSP { get { return _tenSP; } set { _tenSP = value; } }
        public decimal Gia { get { return _gia; } set { _gia = value; } }
        public int SoLuongTon { get { return _soLuongTon; } set { _soLuongTon = value; } }

        // Constructor không tham số (Bắt buộc phải có để dùng được Object Initializer đẹp nhất)
        public SanPham() { }

        // Constructor đầy đủ tham số
        public SanPham(string maSP, string tenSP, decimal gia, int soLuongTon)
        {
            _maSP = maSP;
            _tenSP = tenSP;
            _gia = gia;
            _soLuongTon = soLuongTon;
        }

        // Phương thức virtual (cho phép class con ghi đè)
        public virtual decimal TinhGiaBan()
        {
            return _gia;
        }

        public virtual string MoTa()
        {
            return $"[Sản Phẩm] Mã: {_maSP} | Tên: {_tenSP} | Tồn kho: {_soLuongTon} | Giá gốc: {_gia:N0}đ";
        }
    }

    // ==========================================
    // 2. CLASS KẾ THỪA: THỰC PHẨM
    // ==========================================
    class SanPhamThucPham : SanPham
    {
        private DateTime _ngayHetHan;
        private int _nhietDoBaoQuan;

        public DateTime NgayHetHan { get { return _ngayHetHan; } set { _ngayHetHan = value; } }
        public int NhietDoBaoQuan { get { return _nhietDoBaoQuan; } set { _nhietDoBaoQuan = value; } }

        public SanPhamThucPham() { }

        // Constructor gọi base() từ lớp cha
        public SanPhamThucPham(string maSP, string tenSP, decimal gia, int soLuongTon, DateTime ngayHetHan, int nhietDo)
            : base(maSP, tenSP, gia, soLuongTon)
        {
            _ngayHetHan = ngayHetHan;
            _nhietDoBaoQuan = nhietDo;
        }

        // Ghi đè phương thức tính giá
        public override decimal TinhGiaBan()
        {
            // Tính số ngày còn lại so với thời điểm hiện tại
            double soNgayConLai = (_ngayHetHan - DateTime.Now).TotalDays;

            // Nếu còn hạn và số ngày <= 3 ngày thì giảm 30%
            if (soNgayConLai >= 0 && soNgayConLai <= 3)
            {
                return Gia * 0.7m; // Giảm 30% (tức là bán với giá 70%)
            }
            return Gia;
        }

        // Ghi đè phương thức mô tả
        public override string MoTa()
        {
            // Gọi base.MoTa() để lấy chuỗi của lớp cha, sau đó cộng thêm chi tiết riêng
            return base.MoTa() + $" | HSD: {_ngayHetHan:dd/MM/yyyy} | Nhiệt độ giữ: {_nhietDoBaoQuan}°C";
        }
    }

    // ==========================================
    // 3. CLASS KẾ THỪA: ĐIỆN TỬ
    // ==========================================
    class SanPhamDienTu : SanPham
    {
        private int _baoHanhThang;
        private string _hangSanXuat;

        public int BaoHanhThang { get { return _baoHanhThang; } set { _baoHanhThang = value; } }
        public string HangSanXuat { get { return _hangSanXuat; } set { _hangSanXuat = value; } }

        public SanPhamDienTu() { }

        // Constructor gọi base()
        public SanPhamDienTu(string maSP, string tenSP, decimal gia, int soLuongTon, int baoHanh, string hangSX)
            : base(maSP, tenSP, gia, soLuongTon)
        {
            _baoHanhThang = baoHanh;
            _hangSanXuat = hangSX;
        }

        // Ghi đè phương thức tính giá
        public override decimal TinhGiaBan()
        {
            if (_baoHanhThang > 12)
            {
                return Gia * 1.1m; // Cộng thêm 10% phí bảo hành
            }
            return Gia;
        }

        // Ghi đè phương thức mô tả
        public override string MoTa()
        {
            return base.MoTa() + $" | Hãng: {_hangSanXuat} | Bảo hành: {_baoHanhThang} tháng";
        }
    }

    // ==========================================
    // 4. HÀM MAIN
    // ==========================================
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Hiển thị tiếng Việt

            // Tạo danh sách hỗn hợp 3 loại bằng kỹ thuật Object Initializer (khởi tạo bằng {})
            List<SanPham> danhSachKho = new List<SanPham>
            {
                // Đối tượng thuộc lớp cha
                new SanPham
                {
                    MaSP = "SP01", TenSP = "Bút bi Thiên Long", Gia = 5_000m, SoLuongTon = 100
                },

                // Đối tượng Thực phẩm (Ngày hết hạn thiết lập sát ngày hiện tại để test giảm giá 30%)
                new SanPhamThucPham
                {
                    MaSP = "TP01", TenSP = "Sữa tươi Vinamilk", Gia = 10_000m, SoLuongTon = 50,
                    NgayHetHan = DateTime.Now.AddDays(2), // Còn 2 ngày hết hạn
                    NhietDoBaoQuan = 4
                },

                // Đối tượng Điện tử (Bảo hành > 12 tháng để test tăng giá 10%)
                new SanPhamDienTu
                {
                    MaSP = "DT01", TenSP = "Laptop Dell XPS", Gia = 20_000_000m, SoLuongTon = 5,
                    BaoHanhThang = 24, HangSanXuat = "Dell"
                }
            };
            Console.WriteLine("NGUYỄN HỮU KHOA 6551071049\n");
            Console.WriteLine("=== DANH SÁCH SẢN PHẨM & TÍNH ĐA HÌNH ===");

            decimal tongGiaTriKho = 0;

            // Dùng foreach duyệt qua danh sách
            foreach (SanPham sp in danhSachKho)
            {
                // 1. Thấy rõ Đa hình (Polymorphism) ở đây:
                // Mặc dù biến 'sp' có kiểu là SanPham, nhưng khi chạy nó sẽ tự biết 
                // gọi hàm MoTa() và TinhGiaBan() tương ứng của lớp con Thực Phẩm hay Điện Tử.
                Console.WriteLine(sp.MoTa());
                Console.WriteLine($" => Giá bán thực tế: {sp.TinhGiaBan():N0}đ");
                Console.WriteLine("---------------------------------------------------------");

                // 2. Tính tổng giá trị kho hàng (Giá gốc * Số lượng tồn)
                tongGiaTriKho += (sp.Gia * sp.SoLuongTon);
            }

            Console.WriteLine($"\nTỔNG GIÁ TRỊ KHO HÀNG (Giá gốc * Số lượng): {tongGiaTriKho:N0} VNĐ");
            

            Console.ReadLine();
        }
    }
}