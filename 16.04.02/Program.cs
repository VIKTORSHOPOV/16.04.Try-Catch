using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._04._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number <= 0)
                {
                    throw new Exception("Invalid Number");
                }

                double result = Math.Sqrt(number);
                Console.WriteLine(result);
            }
            catch (Exception ae)
            {
                Console.WriteLine(ae.Message);
            }
            finally { Console.WriteLine("Program Finished..."); }
        }
    }
}
