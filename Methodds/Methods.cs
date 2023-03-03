
internal class Methods
{
    static void Main(string[] args)
    {
        Add();
        Add2(10, 20);

        int n1 = 10;
        int n2 = 20;
        var result = Add3(n1, n2);

        Console.WriteLine(result);
        Console.WriteLine(n1);
        Console.WriteLine(MultiPly(10,20));
        Console.WriteLine(MultiPly(10,20,30));
        Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
        Console.ReadLine();
    }

    static void Add()
    {
        Console.WriteLine("Added");
    }
    static int Add2(int n1, int n2) // out değer vermesende çalışır.(metodların setlenmesi gerekir)
    {
        var result = n1 + n2;
        return result;
    }
    static int Add3(int n1, int n2) // ref değer vermeyi zorunlu kılar
    {
        n1 = 30;
        return n1 + n2;
    }
    static int MultiPly(int n1, int n2)
    {
        return n1 * n2;
    }
    static int MultiPly(int n1, int n2, int n3)
    {
        return n1 * n2 * n3;
    }
    static int Add4(params int[] n)
    {
        return n.Sum();
    }

}