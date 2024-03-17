namespace LAB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items:");
            int number = 10;
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("Number of items set to 10 beacuse it cannot be negative.");
                    number = 10;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Default number of items set to 10.");
            }
            Console.WriteLine("Enter the seed:");
            int seed = 0;
            try
            {
                seed = int.Parse(Console.ReadLine());
                if (seed < 0)
                {
                    Console.WriteLine("Seed set to 10 beacuse it cannot be negative.");
                    seed = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Default seed set to 0.");
            }
            Backpack backpack = new Backpack(number, seed);
            backpack.DisplayList();
            Console.WriteLine("Enter the capacity:");
            int capacity = 10;
            try
            {
                capacity = int.Parse(Console.ReadLine());
                if (capacity < 0 )
                {
                    Console.WriteLine("Capacity set to 10 beacuse it cannot be negative.");
                    capacity = 10;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Default capacity set to 10.");
            }
            Result result = backpack.Solve(capacity);
            string text = result.ToString();
            Console.WriteLine(text);
        }
    }
}
