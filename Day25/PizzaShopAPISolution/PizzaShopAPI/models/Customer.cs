namespace PizzaShopAPI.models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        
        public string? Role { get; set; }
        public int UserId { get;  set; }
        public object Email { get;  set; }
        public object Orders { get; set; }
    }
}
