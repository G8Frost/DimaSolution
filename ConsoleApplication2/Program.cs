using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i != 8)
            {
                i++;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int j = 1;
            while (j!=8)
            {
                j++;
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
}
