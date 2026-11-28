using EFCore.Contexts;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region How To Migrate
            //to add db to sql server:

            ///1.Install-Package "Microsoft.EntityFrameworkCore.SqlServer" -version 9.0.23
            ///2.create Compnydbcontext that inhert DbContext
            ///3.override OnConfiguring and set db conection string
            ///4.add dbset<> for class (Models) that want to be tables
            ///5.install Package Microsoft.EntityFrameworkCore.Tools
            ///6.Add-Migration "InitialCreate"
            ///7.Update-Database
            #endregion

            #region CRUD Operations [create, read, update, delete]
            ///Unmanaged code
            //CompanyDbContext db = new CompanyDbContext();
            //try { }
            //catch { }
            //finally { db.Dispose(); } //close connection

            ///clr take control
            //using (CompanyDbContext db = new CompanyDbContext())
            //{
            //    ///crud
            //    ///code
            //    ///crud
            //}

            ///Clr Take Control
            //using CompanyDbContext db = new CompanyDbContext();

            //Employee employee = new Employee()
            //{
            //    FirstName = "Ahmed",
            //    LastName = "Ali",
            //    Salary = 30000,
            //    Age = 22
            //};

            //Department department = new Department() { Name = "HR" };

            //Console.WriteLine(db.Entry(employee).State);
            //Console.WriteLine(db.Entry(department).State);
            /////deatached
            /////added => inserted in memory only
            /////Modefied => updated in memory only
            /////deleted => deleted in memory only
            /////unchanged => indatabase same as in memory

            /////Tracker
            #region Create
            //db.Employees.Add(employee); //=> added in memory
            //db.Add(employee); //=> added in memory
            //db.Set<Department>().Add(department); //=> added in memory
            //db.Entry(employee).State = EntityState.Added; //=> added in memory

            //Console.WriteLine(db.Entry(employee).State); // deatached
            //db.Employees.Add(employee); //just in memory
            //Console.WriteLine(db.Entry(employee).State); // added
            //db.SaveChanges();  //in database same as in memory
            //Console.WriteLine(db.Entry(employee).State); // unchanged
            #endregion

            #region Read
            #region Multi Element
            //select * from employees => and not excuite
            //var result = (from emp in db.Employees
            //              where emp.Salary > 2000
            //              select emp).ToList(); //quary not run yet in db

            ////select * from employees where salary > 2000
            //var result02 = db.Employees.Where(emp => emp.Salary > 2000).ToList();

            ////select * from employees
            ////=> excuit in db
            ////=>then get all employees in memory
            ////=>then filter from memory to get combatible with condition
            //var result03 = db.Employees.ToList().Where(emp => emp.Salary > 2000);

            //foreach (var emp in result)
            //{
            //    Console.WriteLine($"Id: {emp.Id}, Name: {emp.FirstName} {emp.LastName}, Salary: {emp.Salary}, Age: {emp.Age}");
            //}
            #endregion
            #region Single Element
            //var Emp = (from emp in db.Employees
            //           where emp.Salary > 2000
            //           select emp)
            //           //.First() //top(1) => select top(1) * from Employees where emp.Salary > 5000
            //           //.FirstOrDefault() //top(1) => select top(1) * from Employees where emp.Salary > 5000
            //           //.Single()    ////top(2) => select top(2) * from Employees where emp.Salary > 5000
            //           .SingleOrDefault() ////top(2) => select top(2) * from Employees where emp.Salary > 5000
            //           ; //quary not run yet in db
            //if (Emp is not null)
            //    Console.WriteLine($"Id : {Emp.Id} , firstname : {Emp.FirstName} , salary : {Emp.Salary} , age : {Emp.Age}");
            #endregion
            #region Tracking Vs NoTracking
            //db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //var Emp = (from emp in db.Employees
            //           where emp.Salary > 2000
            //           select emp)
            //           //.AsNoTracking()
            //           .AsTracking()
            //           .First();
            //Console.WriteLine(db.Entry(Emp).State);
            //Emp.FirstName = "test";
            //Console.WriteLine(db.Entry(Emp).State);
            #endregion
            #endregion

            #region Update
            //var Emp = db.Employees.Where(e => e.Id == 1).AsTracking().FirstOrDefault();
            //if (Emp is not null)
            //{
            //    Console.WriteLine(db.Entry(Emp).State);
            //    Emp.FirstName = "Test";
            //    Emp.Salary = 6000;
            //    Console.WriteLine(db.Entry(Emp).State);
            //    db.SaveChanges();
            //    Console.WriteLine(db.Entry(Emp).State);
            //}
            #endregion

            #region Delete
            //var Emp = db.Employees.Where(e => e.Id == 1).AsTracking().FirstOrDefault();
            //if(Emp is not null)
            //{
            //    Console.WriteLine(db.Entry(Emp).State);
            //    db.Employees.Remove(Emp);
            //    Console.WriteLine(db.Entry(Emp).State);
            //    db.SaveChanges();
            //    Console.WriteLine(db.Entry(Emp).State);
            //}
            #endregion
            #endregion

            #region Mapping RealtionShip
            ///3. how to implment in code
            ///     3.1 fk property [class name + pk name]
            ///     3.2 Navigational property [class name]
            ///     by defaulty 
            #endregion

            #region Mapping Inheritance
            using InheritanceDbContext dbContext = new InheritanceDbContext();
            FullTime fullTime = new FullTime()
            {
                Name = "Ahmed",
                Salary = 6000,
                HiringDate = DateOnly.FromDateTime(DateTime.Now),
                Age = 22
            };

            PartTime partTime = new PartTime()
            {
                Name = "Ali",
                HoureRate = 300,
                HoursCount = 10,
                Age = 20
            };

            #region TPH
            #region TWO DBSet
            //dbContext.FullTimePerson.Add(fullTime);
            //dbContext.PartTimePerson.Add(partTime);
            //dbContext.SaveChanges();

            //var fulltimeperson = (from f in dbContext.FullTimePerson select f).ToList();
            //var partimeperson = (from f in dbContext.PartTimePerson select f).ToList();
            #endregion
            #region One DBSet
            //dbContext.Persons.Add(fullTime);
            //dbContext.Persons.Add(partTime);
            //dbContext.SaveChanges();

            //var fulltimeperson = (from f in dbContext.Persons.OfType<FullTime>() 
            //                      select f).ToList();

            //var partimeperson = (from f in dbContext.Persons.OfType<PartTime>() 
            //                     select f).ToList();

            //var persons = (from f in dbContext.Persons select f).ToList();
            #endregion
            #endregion
            #endregion

            #region work with multi dbcontext
            ///Add-Migration "InitialCreateTPH" -Context "InheritanceDbContext" -OutputDir "MigrationsForInheritanceDbContext"
            /// Update-Database -Context "InheritanceDbContext"
            #endregion
        }
    }
}
