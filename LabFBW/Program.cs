using System;

namespace LabFBW
{
    class Program
    {
        static void Main(string[] args)
        {
            var fbw = new FizzBuzzWoof();
            fbw.Run();


            Console.WriteLine("\n\n-----------------------------------");
            Console.WriteLine("End of Demo. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
