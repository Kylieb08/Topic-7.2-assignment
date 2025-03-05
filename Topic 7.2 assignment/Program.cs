namespace Topic_7._2_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name;

            //Assignment one
            //Console.WriteLine("Assignment one");
            //Console.WriteLine();

            //for (int i = 10; i > -1; i = i - 1)
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine(i);
            //}
            //Thread.Sleep(1000);
            //Console.WriteLine("Blast off!");
            //Console.ReadLine();

            ////Assignment two
            //Console.WriteLine("Assignment two");
            //Console.WriteLine();
            //Thread.Sleep(1000);

            //Console.WriteLine("X \t Y");
            //Console.WriteLine("----------");
            //for (int x = -10; x < 12; x = x + 2)
            //{
            //    Thread.Sleep(1000);
            //    int y = (int)Math.Pow(x, 2);
            //    Console.WriteLine(x + "\t" + y);
            //}
            //Console.ReadLine();

            //Assignment three
            Console.WriteLine("Assignment three");
            Console.WriteLine();

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine();
            for (int i = 0; i < 10; i = i + 1)
            {
                Thread.Sleep(1000);
                Console.WriteLine(name);
            }
        }
    }
}
