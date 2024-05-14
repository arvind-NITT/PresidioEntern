using MainRequestTrackerAPI.Models;

namespace MainRequestTrackerAPI.Interfaces
{
    public interface IEmployeeService
    {
        public Task<Employee> GetEmployeeByPhone(string phoneNumber);
        public Task<Employee> GetEmployeeByName(string name);
        public Task<Employee> UpdateEmployeePhone(int id, string phoneNumber);
        public Task<IEnumerable<Employee>> GetEmployees();

    }
}
