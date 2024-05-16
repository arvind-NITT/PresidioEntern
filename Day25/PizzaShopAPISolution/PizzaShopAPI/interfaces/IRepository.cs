using PizzaShopAPI.models;

namespace PizzaShopAPI.interfaces
{
    public interface IRepository<K, T> where T : class
    {
        public Task<T> Add(T item);
        public Task<T> Delete(K key);
        public Task<T> Update(T item);
        public Task<T> Get(K key);
        public Task<IEnumerable<T>> Get();
        Task<IEnumerable<Pizza>> GetAll();
        Task<Pizza> GetById(int id);
    }
}
