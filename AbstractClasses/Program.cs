using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
       Database database = new SqlServer();
        database.Added();
        database.Delete();

       Database database1= new Oracle();
        database1.Added();
        database1.Delete();

        Console.ReadLine();
    }
}
abstract class Database
{
    public void Added()
    {
        Console.WriteLine("Default Added");
    }
    public abstract void Delete();
}

class SqlServer : Database
{
    public override void Delete()
    {
        Console.WriteLine("Deleted by Sql");
    }
}
class Oracle : Database
{
    public override void Delete()
    {
       Console.WriteLine("Deleted by Oracle");
    }
}