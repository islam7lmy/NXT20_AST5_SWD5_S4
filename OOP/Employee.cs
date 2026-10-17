using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Employee
    {
        //int Id;
        //string Name; //max legnth = 20
        //decimal Salary; //min 2000
        //int Age; //min 18 max 60

        public Employee()
        {
            Id = default;
            Name = string.Empty;
            Salary = 2000;
            Age = 18;
        }

        public Employee(int _id, string _name, decimal _salary, int _age)
        {
            this.Id = _id;

            //this.Name = _name.Length <= 20 ? _name : _name.Substring(0,20);
            this.Name = _name;

            //this.Salary = _salary >= 2000 ? _salary : 2000;
            //SetSalary(_salary);
            this.Salary = _salary;

            this.Age = _age;
            //if (_age >= 18 && _age <= 60)
            //    this.Age = _age;
            //else if (_age < 18)
            //    this.Age = 18;
            //else if (_age > 60)
            //    this.Age = 60;
        }

        //encapsulation : seprate the data defintion (attributes) from it's usage (GetterSetter or Property)
        #region Name
        private string _name;

        public string Name
        {
            get { return _name ?? "N/A"; }
            set { _name = value.Length <= 20 ? value : value.Substring(0, 20); }
        }
        #endregion

        #region 1. full property [field + property]

        // getter & setter
        public decimal GetSalary()
        {
            return Salary;
        }

        public void SetSalary(decimal value)
        {
            this.Salary = value >= 2000 ? value : 2000;
        }

        private decimal _salary;

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value >= 2000 ? value : 2000; }
        }
        #endregion

        #region Automatic property [backingfield +  property]
        public int Id { get; private set; }
        #endregion

        #region Deductions Automatic Property [Get Only] => derived attribute
        public decimal Deductions
        {
            get
            {
                return Salary * .2m;
            }
        }
        #endregion

        #region Age
        private int _age;

        public int Age
        {
            get { return _age; }
            set 
            {
                if (value >= 18 && value <= 60)
                    _age = value;
                else if (value < 18)
                    _age = 18;
                else if (value > 60)
                    _age = 60;
            }
        }

        #endregion

    }
}
