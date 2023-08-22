namespace Randomizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            //int value = rand.Next(0, 5);
            //Console.WriteLine(value);

            for(int i = 0; i < 20;  i++)
            {
                int value = rand.Next(0, 5);
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}