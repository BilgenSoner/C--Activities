using Classes;

internal class Program
{
    static void Main(string[] args)
    {
        Classes.CustomerManager customerManager = new Classes.CustomerManager();
        customerManager.Add();
        customerManager.Update();

        Classes.ProductManager productManager = new Classes.ProductManager();
        productManager.Add();
        productManager.Update();

        Customer customer = new Customer();
        customer.ID = 1;
        customer.FirstName = "Soner";
        customer.LastName = "BİLGEN";
        customer.City = "Bilecik";

        Customer customer2 = new Customer
        {
            ID = 2,
            FirstName = "Furkan",
            LastName = "Yüksel",
            City = "Antalya",
        };

        Console.ReadLine();
    }
    
    
}