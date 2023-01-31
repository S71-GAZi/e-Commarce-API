namespace e_Commarce_API.Models
{
    public class Brand
    {
        public Brand()
        {
            this.Products = new HashSet<Product>();
        }
        public int BrandId { get; set; }
        public string  BrandName { get; set; }
        public string BrandLogo { get; set; }
        public string BrandDescription { get; set;}

        public ICollection<Product> Products { get; set; }

       

        // Default property=================
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Check { get; set; }
    }
}
