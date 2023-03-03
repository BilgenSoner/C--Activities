class Program
{
    static void Main(string[] args)
    {
        SqlServer sqlServer = new SqlServer();
        sqlServer.Add();

        mySql mySql = new mySql();
        mySql.Add();

        Console.ReadLine();

    }
    
}
class Database
{
    public virtual void Add()
    {
        Console.WriteLine("Added by default");
    }
    public virtual void Delete()
    {
        Console.WriteLine("Deleted by default");
    }
}
class SqlServer : Database
{
    public override void Add()
    {
        Console.WriteLine("SqlServer method working in add()");
        //base.Add();
    }
}
class mySql : Database
{

}