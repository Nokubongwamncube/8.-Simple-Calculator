using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");

            int numb1 = Convert.ToInt32(Console.ReadLine());

            double numb2 = Convert.ToInt32(Console.ReadLine());
            double numb3 = numb1 + numb2;

            Console.WriteLine(numb1 + " + " + numb2 + " + " + " = " + numb3);





         


            Console.ReadLine();
        }
    }
}
