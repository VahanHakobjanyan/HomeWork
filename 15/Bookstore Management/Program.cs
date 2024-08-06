using Bookstore_Management.Books;

namespace Bookstore_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin1 = new Admin();
            Inventory inventory = new Inventory(admin1);

            Book Orwell1984 = new Book("1984", "G.Orwell", " 46237423", 600, 15, "aserfdasfas", Category.Fiction);

            admin1.AddBookToInventory(inventory, Orwell1984);

            Customer customer = new Customer();

            customer.BrowseAll(inventory);
            customer.BrowseByCategory(inventory, Category.Fiction);
            customer.ViewBook(Orwell1984);
            customer.AddToCart(Orwell1984);
            Console.ReadKey();
        }
    }
}
