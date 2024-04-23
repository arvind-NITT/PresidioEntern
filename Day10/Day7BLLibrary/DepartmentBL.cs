using Day7ClassModelLibrary;
using Day7DALLibrary;

namespace Day7BLLibrary
{
    public class DepartmentBL : IDepartmentService
    {
        readonly IRepository<int, Department> _departmentRepository;
        public DepartmentBL(IRepository<int, Department> departmentRepository)
        {
            //_departmentRepository = new DepartmentRepository();//Tight coupling
            _departmentRepository = departmentRepository;//Loose coupling
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
            List<Department> departments = _departmentRepository.GetAll();
            foreach (Department department in departments)
            {
                if (department.Name == departmentOldName)
                {
                    department.Name = departmentNewName;
                    return department;
                }
            }
            throw new DepartmentNotFoundException();
        }

        public Department GetDepartmentById(int id)
        {
            Department department = _departmentRepository.Get(id);
            if (department != null)
            {
                return department;
            }
            throw new DepartmentNotFoundException();
        }

        public Department GetDepartmentByName(string departmentName)
        {
            var departments = _departmentRepository.GetAll();
            for (int i = 0; i < departments.Count; i++)
                if (departments[i].Name == departmentName)
                    return departments[i];
            throw new DepartmentNotFoundException();
        }

        public int GetDepartmentHeadId(int departmentId)
        {
            Department department = _departmentRepository.Get(departmentId);
            if (department != null)
            {
                return department.Department_Head;
            }
            throw new DepartmentNotFoundException();

        }
    }
}
