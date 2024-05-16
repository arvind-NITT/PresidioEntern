namespace PizzaShopAPI.models.DTOs
{
    public class SuccessRegister
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public Customer Customer { get; set; }
    }
}
