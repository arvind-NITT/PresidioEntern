using RequestTrackerAPI.models;

namespace RequestTrackerAPI.interfaces
{
    public interface ITokenService
    {
        public string GenerateToken(Employee employee);
    }
}
