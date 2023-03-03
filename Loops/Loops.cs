internal class Loops
{
    private static void Main(string[] args)
    {
        if (IsPrimeNumber(8))
        {
            Console.WriteLine("this is Prime number");
        }
        else
        {
            Console.WriteLine("this not Prime number");
        }
        /*
            for(int i=0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        */
        /*
            int s1 = 100;
            while (s1>=0)
            {
                Console.WriteLine(s1--);
            }
        */
        /*
            int s1 = 10;
            do { 
            Console.WriteLine(s1);
            s1--;
            }while (s1 >= 11);
        */

        Console.ReadLine();
    }
    public static bool IsPrimeNumber(int s1)
    {
        bool result = true;
        for (int i = 2; i < s1 - 1; i++)
        {
            if (s1 % i == 0)
            {
                return false;
                i = s1;
            }

        }
        return result;
    }
}