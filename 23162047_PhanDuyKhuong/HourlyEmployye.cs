using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    public class HourlyEmployye : Person
    {
        private double hourSalary;
        private int totalHour;
        public double HourSalary { get => hourSalary; set => hourSalary = value; }
        public int TotalHour { get => totalHour; set => totalHour = value; }
        public HourlyEmployye() { }
        public HourlyEmployye(string firstName, string lastName, Address address, double hourSalary, int totalHour) : base (firstName, lastName, address)
        {
            HourSalary = hourSalary;
            TotalHour = totalHour;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap HourSalary(VND): ");
            HourSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap TotalSalary: ");
            TotalHour = int.Parse(Console.ReadLine());
        }
        public override double pay()
        {
            return HourSalary*TotalHour;
        }
        public override string toString()
        {
            return $"{base.toString()} HourlyEmployee[ HourSalary: {HourSalary}, TotalHour: {TotalHour},Salary: {pay()} VND] ";
        }
    }
}
