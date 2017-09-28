using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.Parse(Console.ReadLine());
            while (max != 0)
            {
                Console.Write("Enter your name here ----> ");
                string name = Console.ReadLine();
                Console.WriteLine("Bravo!");
            }
        }
    }
}
