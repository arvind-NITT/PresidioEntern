using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RequestTrackerModelLibrary;

namespace RequestTrackerDALLibrary
{
    /* public class EmployeeRepository : IRepository<int, Employee>
     {
         private readonly RequestTrackerContext _context;

         public EmployeeRepository(RequestTrackerContext context) 
         {
             _context = context;
         }
         public async Task<Employee> Add(Employee entity)
         {
             _context.Add(entity);
             await _context.SaveChangesAsync();
             return entity;
         }

         public async Task<Employee> Delete(int key)
         {
             var employee = await Get(key);
             if (employee != null)
             {
                 _context.Employees.Remove(employee);
                 await _context.SaveChangesAsync();
             }
             return employee;
         }

         public async Task<Employee> Get(int key)
         {
             var employee = _context.Employees.SingleOrDefault(e => e.Id == key);
             return employee;
         }

         public async Task<IList<Employee>> GetAll()
         {
             return await _context.Employees.ToListAsync();
         }

         public async Task<Employee> Update(Employee entity)
         {
             var employee = await Get(entity.Id);
             if (employee != null)
             {
                 _context.Entry<Employee>(employee).State = EntityState.Modified;
                 await _context.SaveChangesAsync();
             }
             return employee;
         }
     }*/
    public class EmployeeRepository : IRepository<int, Employee>
    {
        private readonly RequestTrackerContext _context;

        public EmployeeRepository(RequestTrackerContext context)
        {
            _context = context;
        }

        public async Task<Employee> Add(Employee entity)
        {
            try
            {
                _context.Employees.Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateException ex)
            {
                // Handle database update exception
                // You may want to log the exception or handle it in a specific way
                // For example, if it's a violation of unique constraints, you can catch specific DbUpdateException types
                // and provide a more meaningful error message to the user.
                Console.WriteLine($"Error occurred while adding employee: {ex.Message}");
                throw; // Re-throw the exception to propagate it upwards
            }
        }

        public async Task<Employee> Delete(int key)
        {
            var employee = await Get(key);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
            return employee;
        }

        public async Task<Employee> Get(int key)
        {
            var employee = await _context.Employees.FindAsync(key);
            return employee;
        }

        public async Task<IList<Employee>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> Update(Employee entity)
        {
            try
            {
                var employee = await Get(entity.Id);
                if (employee != null)
                {
                    _context.Entry<Employee>(employee).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                return employee;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // Handle concurrency exception
                Console.WriteLine($"Concurrency error occurred while updating employee: {ex.Message}");
                throw;
            }
            catch (DbUpdateException ex)
            {
                // Handle database update exception
                Console.WriteLine($"Error occurred while updating employee: {ex.Message}");
                throw;
            }
        }
    }

}
