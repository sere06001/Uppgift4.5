using System;
namespace Uppgift4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string heltal = Console.ReadLine();
            for (int i = 0; i < heltal.Length; i++)
            {
                string tecken = heltal[i].ToString();
                int siffra = int.Parse(tecken);
                if (siffra == 9)
                {
                    siffra = -1;
                }
                Console.Write($"{siffra + 1}");
            }
            Console.ReadKey();
        }
    }
}