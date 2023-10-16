using System.ComponentModel.DataAnnotations.Schema;

namespace e_Commarce_API.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }

        public ICollection<Subcategory> Subcategories { get; set; } 
        public string IsActive { get;set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
