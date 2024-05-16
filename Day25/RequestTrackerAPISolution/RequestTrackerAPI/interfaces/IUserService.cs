using RequestTrackerAPI.models.DTOs;
using RequestTrackerAPI.models;

namespace RequestTrackerAPI.interfaces
{
    
        public interface IUserService
        {
            public Task<LoginReturnDTO> Login(UserLoginDTO loginDTO);
            public Task<Employee> Register(EmployeeUserDTO employeeDTO);
        }
    
}
