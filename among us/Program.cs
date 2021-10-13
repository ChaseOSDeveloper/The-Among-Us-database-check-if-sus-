using System;

namespace among_us
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("welcome to sus explorer 2021 edition");
                Console.WriteLine("search sus");
                string name = Console.ReadLine();
                Console.WriteLine("alert:");
                Console.WriteLine("ok searching sus...");
                imposter imposter = new imposter(name);
                Console.WriteLine("verified no sus");
            }
        }
    }
}
