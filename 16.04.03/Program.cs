using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _16._04._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (!(number >= 1 && number <= 12))
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine(new DateTime(DateTime.Now.Year, number, 1).ToString("MMMM"));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally { Console.WriteLine("Program Finished"); }
        }
    }
}
