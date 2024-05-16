using PizzaShopAPI.interfaces;
using PizzaShopAPI.models;
using PizzaShopAPI.context;
using Microsoft.EntityFrameworkCore;

namespace PizzaShopAPI.Repositories
{
    public class PizzaRepository : IRepository<int, Pizza>
    {
        private PizzaShopContext _context;

        public PizzaRepository(PizzaShopContext context)
        {
            _context = context;
        }
        public async Task<Pizza> Add(Pizza item)

        {

            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<Pizza> Delete(int key)
        {
            var Pizza = await Get(key);
            if (Pizza != null)
            {
                _context.Remove(Pizza);
                await _context.SaveChangesAsync();
                return Pizza;
            }
            throw new Exception("No Pizza with the given ID");
        }

        public async Task<Pizza> Get(int key)
        {
            return (await _context.Pizzas.SingleOrDefaultAsync(u => u.PizzaId == key)) ?? throw new Exception("No Pizza with the given ID");
        }

        public async Task<IEnumerable<Pizza>> Get()
        {
            return (await _context.Pizzas.ToListAsync());
        }

        public Task<IEnumerable<Pizza>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Pizza> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Pizza> Update(Pizza item)
        {
            var Pizza = await Get(item.PizzaId);
            if (Pizza != null)
            {
                _context.Update(item);
                await _context.SaveChangesAsync();
                return Pizza;
            }
            throw new Exception("No Pizza with the given ID");
        }
    }
}
