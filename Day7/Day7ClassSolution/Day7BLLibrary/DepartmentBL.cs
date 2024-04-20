using Day7ClassModelLibrary;
using Day7DALLibrary;

namespace Day7BLLibrary
{
    public class DepartmentBL : IDepartmentService
    {
        readonly IRepository<int, Department> _departmentRepository;
        public DepartmentBL()
        {
            _departmentRepository = new DepartmentRepo();
        }
         
        public int AddDepartment(Department department)
        {
            
                var result = _departmentRepository.Add(department);
                if (result != null)
                {
                    return result.Id;
                }
            throw new DuplicateDepartmentNameException();
            
            
        }

        public Department ChangeDepartmentName(string departmentOldName, string departmentNewName)
        {
            throw new NotImplementedException();
        }

        public Department GetDepartmentById(int id)
        {
            throw new NotImplementedException();
        }

        public Department GetDepartmentByName(string departmentName)
        {
            throw new NotImplementedException();
        }

        public int GetDepartmentHeadId(int departmentId)
        {
            throw new NotImplementedException();
        }
    }
}
