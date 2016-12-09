using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give Mazedur's number:");
            double aNumber = Convert.ToDouble(Console.ReadLine());
            double bNumber = Convert.ToDouble(Console.ReadLine());
            //Add(12, 5);
            //Console.WriteLine("Give ur number :");
            Console.WriteLine(Add(aNumber , bNumber));
            
            Console.Read();
        }
        public static double Add(double aNumber , double bNumber)
        {
            return aNumber + bNumber;
        }
    }
}
