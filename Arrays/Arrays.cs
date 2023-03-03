internal class Arrays
{
    private static void Main(string[] args)
    {
        String[] students = new string[3] { "Engin", "Soner", "Mehmet" };
        /*  students[3] = "Ferhat"; 4. eleman olarak kabul ediyor.
            String[] students2 = { "Ayşe", "Fatma", "Hayriye" };

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        */
        String[,] regions = new string[7, 3]
        {
            {"İstanbul","İzmit","Balıkesir" },
            {"Ankara","Konya","Kırıkale" },
            {"Antalya","Mersin","Adana" },
            {"Rize","Trabzon","Ordu" },
            {"İzmir","Muğla","Manisa" },
            {"Ağrı","Erzurum","Bitlis" },
            {"Şırnak","Mardin","Gaziantep" }
        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i, j]);
            }
            Console.WriteLine("************");
        }

        Console.ReadLine();
    }
}