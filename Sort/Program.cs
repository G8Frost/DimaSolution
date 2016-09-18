using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main()
        {
            int[] Array = new[] {8, 3, 1, 5, 2, 7, 4, 0, 6, 9};
            ShowArray( Array );
            Console.WriteLine();
            Console.Write( "Выберите метод(BubbleSort(1), ShakerSort(2), Find(3)): " );
            String SelectSort = Console.ReadLine();
            switch ( SelectSort )
            {
                case "1":
                    BubbleSort( Array );
                    break;
                case "2":
                    ShakerSort(Array);
                    break;
                case "3":
                    Find(Array);
                    break;
                default:
                    Console.WriteLine("Метод не найден");
                    Main();
                    break;
            }
            ShowArray( Array );
            Console.ReadLine();
            Main();
        }

        static void BubbleSort( int[] Array )
        {
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
        }

        static void SwapElement( int[] Array, int i1, int i2 )
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

        static void ShakerSort( int[] Array2 )
        {
            int Left = 0;
            int Right = Array2.Length - 1;
            while ( Left < Right )
            {
                for ( int i = Left; i < Right; i++ )
                {
                    if ( Array2[i] > Array2[i + 1] )
                    {
                        SwapElement( Array2, i, i + 1 );
                    }
                }
                Right--;
                for ( int i = Right; i > Left; i-- )
                {
                    if ( Array2[i] < Array2[i - 1] )
                    {
                        SwapElement( Array2, i, i - 1 );
                    }
                }
                Left++;
            }
        }

        static void Find(int[] Array)
        {
            Console.Write("Введите число для поиска: ");
            String select = Console.ReadLine();
            int s = Convert.ToInt32(select);
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == s)
                {
                    Console.WriteLine("Индекс числа: " + (i+1));
                    return;
                }              
            }
            Console.WriteLine("Такого числа нет");
        }
    }
}
