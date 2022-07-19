using System.ComponentModel.DataAnnotations;

namespace WebApi3.Model
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeId { get; set; }

        public string? EmployeeName { get; set; }
        public string? Nationality { get; set; }
        public int age { get; set; }
    }
}
