using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MathandComparisonOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int remainder = 12 % 5;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //int product = 12 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine

            //double quotient = 120.0 / 21;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //    bool trueOrfalse = 12 < 6;
            //    Console.Write(trueOrfalse.ToString());
            //    Console.ReadLine();

            int roomTemp = 69;
            int currentTemp = 72;

            //bool isWarm = currentTemp > roomTemp;
            bool isWarm = currentTemp != roomTemp;

            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
