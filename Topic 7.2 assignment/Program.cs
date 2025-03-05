namespace Topic_7._2_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Assignment one
            Console.WriteLine("Assignment one");
            Console.WriteLine();

            for (int i = 10; i > -1; i = i - 1)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
            Thread.Sleep(1000);
            Console.WriteLine("Blast off!!");
        }
    }
}
