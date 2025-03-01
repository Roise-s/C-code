using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypotenuseCalculatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side A:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B:");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("The hypoteuse is {0}", c);

            Console.ReadKey();
        }
    }
}
