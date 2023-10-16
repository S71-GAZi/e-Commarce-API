using System.ComponentModel.DataAnnotations.Schema;

namespace e_Commarce_API.Models
{
    public class Subcategory
    {
        public int SubcategoryId { get; set; }
        public string  SubcategoryName { get; set; }

        
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        // Default Property=====================
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
