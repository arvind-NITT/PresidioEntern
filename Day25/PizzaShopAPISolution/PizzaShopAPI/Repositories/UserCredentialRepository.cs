using PizzaShopAPI.interfaces;
using PizzaShopAPI.models;
using PizzaShopAPI.context;
using Microsoft.EntityFrameworkCore;

namespace PizzaShopAPI.Repositories
{
    public class UserCredentialRepository : IRepository<int, UserCredential>
    {
        private PizzaShopContext _context;

        public UserCredentialRepository(PizzaShopContext context)
        {
            _context = context;
        }
        public async Task<UserCredential> Add(UserCredential item)
        {

            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<UserCredential> Delete(int key)
        {
            var UserCredential = await Get(key);
            if (UserCredential != null)
            {
                _context.Remove(UserCredential);
                await _context.SaveChangesAsync();
                return UserCredential;
            }
            throw new Exception("No UserCredential with the given ID");
        }

        public async Task<UserCredential> Get(int key)
        {
            return (await _context.UserCredentials.SingleOrDefaultAsync(u => u.UserId == key)) ?? throw new Exception("No UserCredential with the given ID");
        }

        public async Task<IEnumerable<UserCredential>> Get()
        {
            return (await _context.UserCredentials.ToListAsync());
        }

        public Task<IEnumerable<Pizza>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Pizza> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserCredential> Update(UserCredential item)
        {
            var UserCredential = await Get(item.UserId);
            if (UserCredential != null)
            {
                _context.Update(item);
                await _context.SaveChangesAsync();
                return UserCredential;
            }
            throw new Exception("No UserCredential with the given ID");
        }
    }

}
