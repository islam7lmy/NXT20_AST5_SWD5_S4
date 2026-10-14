using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Employee
    {
        int Id;
        string Name; //max legnth = 20
        decimal Salary; //min 2000
        int Age; //min 18 max 60

        public Employee()
        {
            Id = default;
            Name = string.Empty;
            Salary = 2000;
            Age = 18;
        }

        public Employee(int _id, string _name, decimal _salary,int _age)
        {
            this.Id = _id;
            this.Name = _name.Length <= 20 ? _name : _name.Substring(0,20);

            //this.Salary = _salary >= 2000 ? _salary : 2000;
            SetSalary(_salary);

            if (_age >= 18 && _age <= 60)
                this.Age = _age;
            else if (_age < 18)
                this.Age = 18;
            else if (_age > 60)
                this.Age = 60;
        }


        // getter & setter
        public decimal GetSalary()
        {
            return Salary;
        }

        public void SetSalary(decimal value)
        {
            this.Salary = value >= 2000 ? value : 2000;
        }
    }
}
