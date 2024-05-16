using MainRequestTrackerAPI.Models.DTOs;
using MainRequestTrackerAPI.Models;

namespace MainRequestTrackerAPI.Interfaces
{
    public interface IUserService
    {
        public Task<LoginReturnDTO> Login(UserLoginDTO loginDTO);
        public Task<Employee> Register(EmployeeUserDTO employeeDTO);
    }
}
