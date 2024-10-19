using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    public class Address
    {
        private string street;
        private string ward;
        private string city;

        public string Street { get => street; set => street = value; }
        public string Ward { get => ward; set => ward = value; }
        public string City { get => city; set => city = value; }
        public Address() { }
        public Address(string street, string ward, string city)
        {
            Street = street;
            Ward = ward;
            City = city;
        }
        public string toString()
        {
            string s = $"Street: {Street}, Ward: {Ward}, City: {City}";
            return s ;
        }
    }
}
