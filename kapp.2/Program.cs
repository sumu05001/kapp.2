using System;
namespace uppgift4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lönen för 3 anställda är ");
            double lön1 = double.Parse(Console.ReadLine());
            double lön2 = double.Parse(Console.ReadLine());
            double lön3 = double.Parse(Console.ReadLine());
            double lön = (lön1 + lön2 + lön3) / 3;
            Console.WriteLine("Medellönen för personalen är " + lön); ///jhjhj

        }
    }
}