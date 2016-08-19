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
            int j = 0;
            while (i != 8)
            {
                i++;
                while ( j != 8 )
                {
                    j++;;
                     Console.Write( i + "," + j + "  " );
                }
                Console.WriteLine();
                j = 0;
               
            }
            
            Console.ReadLine();
        }
    }
}
