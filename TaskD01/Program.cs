namespace TaskD01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n                Islam's Carpet Cleaning Service    \n");
            Console.WriteLine("\n Estimate for carpet cleaning service\n");
            Console.WriteLine("Number of small carpets:");
            int sc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of large carpets:");
            int lc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35\n");
            Console.WriteLine($"Cost : ${(sc*25)+(lc*35)}");
            Console.WriteLine("Tax  : $6.6");
            Console.WriteLine("===============================\n");
            Console.WriteLine($"Total estimate: ${(sc * 25) + (lc * 35) + 6.6}");
            Console.WriteLine("This estimate is valid for 30 days\n");




        }
    }
}
