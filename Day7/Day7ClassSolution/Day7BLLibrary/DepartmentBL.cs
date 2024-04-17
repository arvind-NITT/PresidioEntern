using Day7ClassModelLibrary;
using Day7DALLibrary;

namespace Day7BLLibrary
{
    public class DepartmentBL
    {
        readonly IRepository<int, Department> _departmentRepository;
        public DepartmentBL()
        {
            _departmentRepository = new DepartmentRepository();
        }
    }
}
