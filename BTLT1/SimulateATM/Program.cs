using System;

class Program
{
    struct taiKhoan
    {
        public string soTK;
        public string ChuTK;
        public decimal soDu;
        public int soLanRutTien;
        public int maPin;
    }


    static bool KiemTraPin(taiKhoan tk)
    {
        int solanMax = 3;
        for (int i = 0; i < solanMax; i++)
        {
            Console.Write("Nhap ma pin: ");
            int pin = int.Parse(Console.ReadLine());

            if (pin == tk.maPin)
            {
                Console.WriteLine("\n=> Dang nhap thanh cong!");
                return true; 
            }
            else
            {
                int soLanConLai = solanMax - i - 1;
                if (soLanConLai > 0)
                {
                    Console.WriteLine($"=> Sai ma pin. Ban con {soLanConLai} lan nhap.");
                }
                else
                {
                    Console.WriteLine("=> Tai khoan bi khoa!");
                }
            }
        }
        return false; 
    }

    static void Menu()
    {
        Console.WriteLine("\n--- MENU ATM ---");
        Console.WriteLine("1. Kiem tra so du");
        Console.WriteLine("2. Rut tien");
        Console.WriteLine("3. Nap tien");
        Console.WriteLine("4. Doi pin");
        Console.WriteLine("5. Xem lich su giao dich");
        Console.WriteLine("6. Thoat");
        Console.Write("Chon chuc nang: ");
    }

    static void RutTien(ref taiKhoan tk)
    {
        Console.Write("Nhap so tien can rut: ");
        decimal soTienRut = decimal.Parse(Console.ReadLine());
        if (soTienRut > tk.soDu)
        {
            Console.WriteLine("=> So du khong du.");
        }
        else
        {
            tk.soDu -= soTienRut;
            Console.WriteLine($"=> Rut tien thanh cong. So du con lai: {tk.soDu:N0}");
            LuuLichSu($"Rut tien: -{soTienRut:N0}"); 
        }
    }

    static void NapTien(ref taiKhoan tk)
    {
        Console.Write("Nhap so tien can nap: ");
        decimal soTienNap = decimal.Parse(Console.ReadLine());
        tk.soDu += soTienNap;
        Console.WriteLine($"=> Nap tien thanh cong. So du hien tai: {tk.soDu:N0}");
        LuuLichSu($"Nap tien: +{soTienNap:N0}");
    }

    // Thêm 'ref' để thay đổi mã PIN gốc
    static void DoiPin(ref taiKhoan tk)
    {
        Console.Write("Nhap ma pin hien tai: ");
        int pinHienTai = int.Parse(Console.ReadLine());
        if (pinHienTai == tk.maPin)
        {
            Console.Write("Nhap ma pin moi: ");
            int pinMoi = int.Parse(Console.ReadLine());
            tk.maPin = pinMoi;
            Console.WriteLine("=> Doi ma pin thanh cong!");
            LuuLichSu("Doi ma PIN");
        }
        else
        {
            Console.WriteLine("=> Sai ma pin hien tai.");
        }
    }

    static string[] lichSuGiaoDich = new string[10];
    static int soLuongGiaoDich = 0;

    static void LuuLichSu(string giaoDich)
    {
        if (soLuongGiaoDich < 10)
        {
            lichSuGiaoDich[soLuongGiaoDich] = giaoDich;
            soLuongGiaoDich++;
        }
        else
        {
            for (int i = 0; i < 9; i++)
            {
                lichSuGiaoDich[i] = lichSuGiaoDich[i + 1];
            }
            lichSuGiaoDich[9] = giaoDich;
        }
    }

    static void InLichSu()
    {
        Console.WriteLine("\n--- LICH SU GIAO DICH ---");
        if (soLuongGiaoDich == 0) Console.WriteLine("Chua co giao dich nao.");
        for (int i = 0; i < soLuongGiaoDich; i++)
        {
            Console.WriteLine($"{i + 1}. {lichSuGiaoDich[i]}");
        }
    }

    static void Main(string[] args)
    {
        taiKhoan tk = new taiKhoan();
        tk.soTK = "1231415";
        tk.ChuTK = "Nguyen Van A";
        tk.soDu = 1000000m;
        tk.maPin = 1333;

   
        if (KiemTraPin(tk))
        {
            bool dangChay = true;
            while (dangChay)
            {
                Menu();
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        Console.WriteLine($"=> So du hien tai: {tk.soDu:N0}");
                        LuuLichSu("Kiem tra so du");
                        break;
                    case "2":
                        RutTien(ref tk); 
                        break;
                    case "3":
                        NapTien(ref tk);
                        break;
                    case "4":
                        DoiPin(ref tk);
                        break;
                    case "5":
                        InLichSu();
                        break;
                    case "6":
                        dangChay = false;
                        Console.WriteLine("=> Cam on quy khach!");
                        break;
                    default:
                        Console.WriteLine("=> Lua chon khong hop le.");
                        break;
                }
            }
        }
    }
}