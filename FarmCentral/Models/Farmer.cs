using System.ComponentModel.DataAnnotations;

namespace FarmCentral.Models
{
    //class to store farmer objects
    public class Farmer
    {

        //Properties
        [Key]
        public int? FarmerId { get; set; } //Primary Key
        [Required]
        public string? Name { get; set; } //Required Property
        public string? Surname { get; set; }

        public string? Email { get; set; }
        public string? FarmName { get; set; }
        public string? Products { get; set; }
        public string? ProductType { get; set; }
    }
}
