internal class Strings
{
    private static void Main(string[] args)
    {
        String sentence = "My name is Soner";
        var result = sentence.Length;
        var result2 = sentence.Clone();
        sentence = "My name is İbrahim";

        bool result3 = sentence.EndsWith("m");
        bool result4 = sentence.StartsWith("s");

        var result5 = sentence.IndexOf(" "); // 0 dan başlayarak sayar
        var result6 = sentence.IndexOf("İbrahim"); // kaçıncı indiste olduğunu gösterir
        var result7 = sentence.LastIndexOf(" ");
        var result8 = sentence.Insert(0, "Hello, ");
        var result9 = sentence.Substring(3,4);
        var result10 = sentence.Replace(" ", "-");
        var result11 = sentence.Remove(2, 5);

        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.WriteLine(result4);
        Console.WriteLine(result5);
        Console.WriteLine(result6);
        Console.WriteLine(result7); 
        Console.WriteLine(result8);
        Console.WriteLine(result9);
        Console.WriteLine(result10);
        Console.WriteLine(result11);
        

    /*
        String city = "Bursa";
        foreach(var s in city)
        {
            Console.WriteLine(s);
        }
    */
        
        Console.ReadLine();
    }
}