using Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        //   InterfacesIntro();
        //   Demo2();

        ICustomerDal[] customerDals = new ICustomerDal[2]
        {
            new SqlCustomerDal(),
            new OracleCustomerDal()
        };

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }
        Console.ReadLine();
    }

    private static void Demo2()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlCustomerDal());
        customerManager.Add(new OracleCustomerDal());
    }

    private static void InterfacesIntro()
    {
        PersonManager manager = new PersonManager();
        manager.Add(new Customer { Id = 1, FirstName = "Soner", LastName = "Bilgen", Address = "Bursa" });

        Student student = new Student();
        manager.Add(new Student { Id = 2, FirstName = "Başak", LastName = "Aslan", Departmant = "Computer Science" });
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }

    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }

    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}