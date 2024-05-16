using PizzaShopAPI.models.DTOs;

namespace PizzaShopAPI.interfaces
{
    public interface ICustomerService
    {
        public Task<SuccessRegister> Login(LoginDTO loginDTO);
        public Task<SuccessRegister> Register(RegisterDTO employeeDTO);
    }
}
