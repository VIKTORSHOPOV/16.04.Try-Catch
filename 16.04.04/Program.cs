using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._04._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] towns = new string[3];
                for (int i = 0; i < towns.Length; i++)
                {
                    towns[i] = Console.ReadLine();
                }
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine(towns[index]);
                Console.WriteLine(towns[index].ToArray().Reverse());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
