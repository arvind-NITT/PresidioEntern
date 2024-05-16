namespace PizzaShopAPI.models.DTOs
{
    public class RegisterDTO : Customer
    {
        public string Password { get; set; }
        public int UserId { get; internal set; }
    }
}
