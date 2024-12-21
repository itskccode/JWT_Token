using System.ComponentModel.DataAnnotations;

namespace JWT_Token.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; } = "n";
        public string LastName { get; set; } = "null";
        public string Email { get; set; } = "null";
        public string PhoneNumber { get; set; }="null";
        public DateTime HireDate { get; set; }
        public string JobTitle { get; set; }= "null";
        public int DepartmentID { get; set; } = 0;
        public int ManagerID { get; set; } = 0;
        public decimal Salary { get; set; }

    }
}
