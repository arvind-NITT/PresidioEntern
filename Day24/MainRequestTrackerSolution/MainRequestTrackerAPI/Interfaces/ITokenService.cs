using MainRequestTrackerAPI.Models;

namespace MainRequestTrackerAPI.Interfaces
{
    public interface ITokenService
    {
        public string GenerateToken(Employee employee);
    }

}
