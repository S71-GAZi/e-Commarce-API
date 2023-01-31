namespace e_Commarce_API.Models
{
    public class Product
    {
        public Product()
        {
            this.Brands = new HashSet<Brand>();
        }
        //-----------------------------------
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public double RetailerPrice { get; set; }
        public double WholesalePrice { get; set; }
        public double VatPasentage { get; set; }
        public bool ActiveForSale { get; set; }
        public bool isLimitade { get; set; }
       
        public string Color { get; set;}
        public string Description { get; set;}
        public string ShortDescrip { get; set;} 
        public string Size { get; set;}
        public string Type { get; set;}
        public string ProductStock { get; set;}
        public string ImageUrl { get; set;}
        public string ImageType { get; set;}
        public   int isDelete { get; set; }
        //Related Table==================
        public int CatagoryId { get; set; }
        public int SubCatagoryId { get; set; }
        public int BrandId { get; set; }
        public int UnitId { get; set; }
        public ICollection<Brand> Brands { get; set; }
        //Default Property================
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
