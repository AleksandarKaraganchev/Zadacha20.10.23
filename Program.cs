using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha20._10._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(x * x + y * y);
            if (distance < r)
            {
                Console.WriteLine("1");
            }
            if (distance == r)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("-3");
            }
        }
    }
}
