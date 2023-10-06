using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Wecome to Package Express. Please follow the instruction below."); 
            
            //User Input for package weight and convert to integer to validate package weight
            
            Console.WriteLine("Please enter your package weight:"); 
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            string weightValidation = packageWeight < 50 ? "Please enter the package height:" : "Package is too heavey to be shipped by Package Express. Have a good day.";
            Console.WriteLine(weightValidation);
            
            //User input for package height,length and width first to validate the dimension then to calculate estimated shipping total
            
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            string heightlengthwidthValidation = packageHeight + packageLength + packageWidth > 50 ? "Your package is too big to be shipped." : "Your shipping cost for package is:";
            Console.WriteLine(heightlengthwidthValidation);

            decimal shippingCost = Convert.ToDecimal(packageHeight * packageLength * packageWidth)*packageWeight/100; 

            //Putting dollar sign in front of shipping cost

            Console.WriteLine(shippingCost.ToString("C"));

            //End of Program message
            
            Console.WriteLine("Thank you for your business!");
            Console.ReadLine();


        }
    }
}
