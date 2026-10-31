using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal class Employee : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Address} :: {Salary}";
        }

        public Employee DeepCopy()
        {
            //this keyword=> refere to object that call method

            //Employee emp = new Employee();
            //emp.Id = this.Id;
            //emp.Name = this.Name;
            //emp.Salary = this.Salary;
            //emp.Address = this.Address;
            //return emp;


            //Employee emp = new Employee()
            //{
            //    Id = this.Id,
            //    Name = this.Name,
            //    Salary = this.Salary,
            //    Address = this.Address
            //};
            //return emp;

            //return new Employee()
            //{
            //    Id = this.Id,
            //    Name = this.Name,
            //    Salary = this.Salary,
            //    Address = this.Address
            //};

            return new Employee(this);
        }

        public object Clone()
        {
            return new Employee(this);
        }

        public Employee()
        {
            
        }

        /// copy constructor => a constructor that takes an object of the same class as a parameter 
        public Employee(Employee emp)
        {
            Id = emp.Id;
            Name = emp.Name;
            Salary = emp.Salary;
            Address = emp.Address;
        }

    }
}
