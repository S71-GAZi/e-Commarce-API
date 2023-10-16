namespace e_Commarce_API.Models
{
    public class Unit
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
