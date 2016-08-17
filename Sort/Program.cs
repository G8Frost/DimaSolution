using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main( string[] args )
        {
            int[] Array = new[] {8, 3, 1, 5, 2, 7, 4, 0, 6, 9};
            ShowArray( Array );

            Console.WriteLine();
            for ( int j = Array.Length - 1; j > 0; j-- )
            {
                for ( int i = 0; i < j; i++ )
                {
                    if ( Array[i] > Array[i + 1] )
                    {
                        SwapElement( Array, i, i + 1 );
                    }
                }
            }
            ShowArray( Array );
            Console.ReadLine();
        }

        private static void SwapElement( int[] Array, int i1, int i2 )
        {
            int a = Array[i1];
            Array[i1] = Array[i2];
            Array[i2] = a;
        }

        static void ShowArray( int[] Array )
        {
            for ( int i = 0; i < Array.Length; i++ )
            {
                Console.Write( Array[i] + " " );
            }
        }
    }
}
