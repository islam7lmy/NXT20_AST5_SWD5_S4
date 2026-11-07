using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OperatorOverloading
{
    class Address
    {
        public string Details { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Address()
        {

        }

        public Address(Address address)
        {
            Details = address.Details;
            City = address.City;
            Country = address.Country;
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public decimal Salary { get; set; }
        public Address Address { get; set; }
        public decimal Detuctions { get { return Salary * .2m; } }

        public Employee()
        {

        }
        public Employee(Employee emp)
        {
            Id = emp.Id;
            FirstName = emp.FirstName;
            LastName = emp.LastName;
            BirthDate = emp.BirthDate;
            Salary = emp.Salary;
            Address = emp.Address; //shallow
            Address = new Address(emp.Address); //Deep
        }

        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   Id == employee.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public static bool operator ==(Employee? left, Employee? right)
        {
            return EqualityComparer<Employee>.Default.Equals(left, right);
        }

        public static bool operator !=(Employee? left, Employee? right)
        {
            return !(left == right);
        }
    }

    static class EmployeeExtintions
    {
        public static EmployeeViewModel ToEmployeeViewModel(this Employee emp)
        {
            return new EmployeeViewModel(emp);
        }
    }

    internal class EmployeeViewModel
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public String Address { get; set; }
        public decimal NetSalary { get; set; }

        public EmployeeViewModel()
        {

        }
        public EmployeeViewModel(Employee emp)
        {
            FullName = $"{emp.FirstName} {emp.LastName}";
            Age = DateTime.Now.Year - emp.BirthDate.Year;
            Address = $"{emp.Address.Details}, {emp.Address.City}, {emp.Address.Country}";
            NetSalary = emp.Salary - emp.Detuctions;
        }

        public override string ToString()
        {
            return $"Name : {FullName}\tAge : {Age}\tAddress : {Address}\tNetSalary : {NetSalary}";
        }

        //public static implicit operator EmployeeViewModel(Employee emp)
        //{
        //    return new EmployeeViewModel(emp);
        //}

        public static explicit operator EmployeeViewModel(Employee emp)
        {
            return new EmployeeViewModel(emp);
        }
    }

    static class IntExtintions
    {
        public static int Add(this int a, int b)
        {
            return a + b;
        }
    }
}
