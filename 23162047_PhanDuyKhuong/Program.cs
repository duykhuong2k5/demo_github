namespace BaiKiemTra
{
    class Program
    {
        static void Main (string[] args)
        {
            QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
            quanLyNhanVien.NhapDanhSach();
            Console.WriteLine("Danh sach nhan vien: ");
            quanLyNhanVien.Xuat();
            quanLyNhanVien.InSoLuongNhanVien();
        }
    }
}