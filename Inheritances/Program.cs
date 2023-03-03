internal class Program
{
    static void Main(string[] args)
    {

        Person[] persons = new Person[2]
        {
           new Customer(),new Student()
        };
    }
}
class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
class Customer : Person   // interface den farklı olarak "Customer : Person" bir kere yapılabilir.
{
    public string City { get; set; }
}
class Student : Person  // örnek Bir çocugun bir tane babası olabilir.
{
    public string Departman { get; set; }
}