using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    public class QuanLyNhanVien
    {
        private List<Person> qlnv = new List<Person>();
        public void NhapDanhSach()
        {
            Console.WriteLine("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap loai nhan vien (1.HourlyEmployee or 2.SalariedEmployee): ");
                int loaiNhanVien = int.Parse(Console.ReadLine());

                Console.WriteLine($"Nhap thong tin nhan vien thu: {i + 1}");

                if (loaiNhanVien == 1)
                {
                    HourlyEmployye nv = new HourlyEmployye();
                    nv.Nhap();
                    qlnv.Add(nv);
                }
                else if (loaiNhanVien == 2)
                {
                    SalariedEmployee nv2 = new SalariedEmployee();
                    nv2.Nhap();
                    qlnv.Add(nv2);
                }

            }
        }
        public void Xuat()
        {
            foreach (var employee in qlnv)
            {
                Console.WriteLine(employee.toString());
            }
        }
        public void InSoLuongNhanVien()
    {
        Console.WriteLine($"So luong nhan vien: {Person.GetCountOfPerson()}");
    }
    }
}
