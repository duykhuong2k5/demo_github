using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private Address address;
        public string FirstName { get => firstName; set => firstName = value; } 
        public string LastName { get => lastName; set => lastName = value; }
        public Address Address { get => address; set => address = value; }
        public static int CountOfPerson { get; private set; } = 0;
        public static int GetCountOfPerson()
        {
            return CountOfPerson;
        }
        public Person() { }
        public Person (string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            CountOfPerson++;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap Ho: ");
            FirstName = Console.ReadLine();
            Console.Write("Nhap ten: ");
            LastName = Console.ReadLine();
            Console.Write("Nhap street: ");
            string street = Console.ReadLine();

            Console.Write("Nhap ward: ");
            string ward = Console.ReadLine();

            Console.Write("Nhap city: ");
            string city = Console.ReadLine();

            Address = new Address(street, ward, city);
            CountOfPerson++;

        }
        public abstract double pay();
        public virtual string toString()
        {
            string s = $"FirstName: {FirstName}, LastName: {LastName}, Address: {Address}";
            return s ;
        }
    }
}
