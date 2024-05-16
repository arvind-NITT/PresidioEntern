using PizzaShopAPI.interfaces;
using PizzaShopAPI.models;
using PizzaShopAPI.context;
using Microsoft.EntityFrameworkCore;

namespace PizzaShopAPI.Repositories
{
    public class CustomerRepository : IRepository<int, Customer>
    {
        private PizzaShopContext _context;

        public CustomerRepository(PizzaShopContext context)
        {
            _context = context;
        }
        public async Task<Customer> Add(Customer item)
        {

            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<Customer> Delete(int key)
        {
            var Customer = await Get(key);
            if (Customer != null)
            {
                _context.Remove(Customer);
                await _context.SaveChangesAsync();
                return Customer;
            }
            throw new Exception("No Customer with the given ID");
        }

        public async Task<Customer> Get(int key)
        {
            return (await _context.Customers.SingleOrDefaultAsync(u => u.UserId == key)) ?? throw new Exception("No Customer with the given ID");
        }

        public async Task<IEnumerable<Customer>> Get()
        {
            return (await _context.Customers.ToListAsync());
        }

        public Task<IEnumerable<Pizza>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Pizza> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> Update(Customer item)
        {
            var Customer = await Get(item.UserId);
            if (Customer != null)
            {
                _context.Update(item);
                await _context.SaveChangesAsync();
                return Customer;
            }
            throw new Exception("No Customer with the given ID");
        }
    }
}
