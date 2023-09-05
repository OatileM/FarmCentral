using System.ComponentModel.DataAnnotations;

namespace FarmCentral.Models
{
    //Employee Object
    public class Employee
    {

        //Properties
        [Key]
        public int EmployeeId { get; set; } //Primary Key
        [Required]
        public string? Name { get; set; } //Required Property
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Boss { get; set; }
        public string? FarmName{ get; set; }
        
    }
}
