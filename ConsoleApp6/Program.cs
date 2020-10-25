using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu = new string[]{ "C - Hello", "E - Boys", "S - Fuck my wife"};

            foreach (string str in menu)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str);

            }
            Console.ReadLine();
        }
    }
}
