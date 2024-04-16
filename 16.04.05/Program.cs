using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._04._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Time time = new Time();
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                time.SetTime(input[0], input[1], input[2]);
                time.ShowTime();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
