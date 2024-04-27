using ShoppingDALLibrary;
using ShoppingBLLibrary;
using ShoppingModelLibrary.Exceptions;
using ShoppingModelLibrary;
namespace ShopingFE
{
    internal class Program
    {
       
        void AddCart()
        {
            CartBL CartBL = new CartBL(new CartRepository(),new CartItemRepository());
            try
            {
                Console.WriteLine("Pleae enter the Cart name");
                string name = Console.ReadLine();
                Cart cart = new Cart() { CustomerId=101 };
                int id = CartBL.AddCart(cart);
                Console.WriteLine("Congrats. We ahve created the Cart for you and the Id is " + id);
                }
            catch (NoCartWithGiveIdException ddne)
            {
                Console.WriteLine(ddne.Message);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
           
        }
    }
}
