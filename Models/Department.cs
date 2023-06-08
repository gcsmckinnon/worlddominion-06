using System.ComponentModel.DataAnnotations;

namespace WorldDominion.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(), MaxLength(250)]
        [Display(Name = "Department Name")]
        public string Name { get; set; }

        [Display(Name = "Department Description")]
        public string? Description { get; set; }

        // Navigation Property
        public List<Product>? Products { get; set; } // Child reference
    }
}
