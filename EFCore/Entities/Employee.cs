using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    #region Properties Mapping
    /// Ef Core Suppotes 4 ways for mapping
    /// 1. by Convention (Default)
    /// 2. Data Annotations [set of attributes used for valdation]
    /// 3. Fluent API (set of methods to do congfigurations)
    /// 4. ConfigurationClass Per Entity => Organized 3rd way 
    #endregion

    #region 1. by Convention (Default)
    //internal class Employee
    //{
    //    /// primary key => [id] , [classname + id]
    //    public int Id { get; set; } //primary key by convantion => identity(1,1) => not allow null
    //    public string FirstName { get; set; } //nvarchar(max) => not allow null
    //    public string? LastName { get; set; } //nvarchar(max) => allow null
    //    public double Salary { get; set; } // float => not allow null
    //    public int? Age { get; set; }  //int => allow null
    //}
    #endregion

    #region 2. Data Annotations [set of attributes used for valdation]
    //[Table("EmployeeInfo", Schema = "dbo")]
    //internal class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int Code { get; set; } //primary key by convantion => identity(1,1) => not allow null

    //    [Required]
    //    [Column(TypeName = DbTypes.Varchar)] //[Column(TypeName = "nvarchar")]
    //    [MaxLength(100)]
    //    [StringLength(50, MinimumLength = 10)]
    //    public string? FirstName { get; set; } //nvarchar(max) => not allow null

    //    public string? LastName { get; set; } //nvarchar(max) => allow null

    //    public double Salary { get; set; } // float => not allow null

    //    [Range(22, 60)]
    //    public int? Age { get; set; }  //int => allow null

    //    [EmailAddress]
    //    public string? Email { get; set; }

    //    public double NetSalary { get => Salary * .9; }

    //    [NotMapped]
    //    public int Test { get; set; }
    //}
    #endregion

    #region 3. Fluent API (set of methods to do congfigurations)
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public double Salary { get; set; }
        public int? Age { get; set; }
    }
    #endregion 

    static class DbTypes
    {
        public const string Varchar = "varchar";
        public const string Nvarchar = "nvarchar";
        public const string Int = "int";
        public const string Float = "float";
    }
}
