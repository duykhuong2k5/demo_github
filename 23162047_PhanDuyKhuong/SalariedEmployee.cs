using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    public class SalariedEmployee : Person
    {
        private double basicSalary;
        private float rate;

        public double BasicSalary { get => basicSalary; set => basicSalary = value; }
        public float Rate { get => rate; set => rate = value; }
        public SalariedEmployee() { }
        public SalariedEmployee(string firstName, string lastName, Address address, double basicSalary, float rate) : base ( firstName, lastName,address)
        {
            BasicSalary = basicSalary;
            Rate = rate;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap BasicSalary: ");
            BasicSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Rate: ");
            Rate = float.Parse(Console.ReadLine());
        }

        public override double pay()
        {
            return BasicSalary*Rate;
        }
        public override string toString()
        {
            return $"{base.toString()} SalariedEmployee[BasicSalary: {BasicSalary}, Rate: {Rate}, Salary: {pay()} VND]";
        }
    }
}
