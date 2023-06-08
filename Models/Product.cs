using System.ComponentModel.DataAnnotations;

namespace WorldDominion.Models
{
    public enum ProductWeightUnit
    {
        Grams,
        Kilograms,
        Pounds,
        Ounces,
        Litres
    }

    public class Product
    {
        public int Id { get; set; }

        [Required()]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        [Required(), MaxLength(300)]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Display(Name = "Product Description")]
        public string? Description { get; set; }

        [Required(), Range(0.01, 9999999.99)]
        [Display(Name = "Price")]
        public double MSRP { get; set; }

        [Required(), Range(0.001, 999999.9999)]
        public decimal Weight { get; set; }

        [Required()]
        [Display(Name = "Unit Type")]
        public ProductWeightUnit WeightUnit { get; set; }

        public string? Photo { get; set; }

        // Navigation Properties
        public Department? Department { get; set; } // Parent relationship
    }
}
