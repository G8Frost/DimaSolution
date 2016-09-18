using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sort
{
	class Program
	{
		static void Main()
		{
			int[] Array = new[] {-1, -2, 8, 3, 1, 5, 2, 7, 4, 0, 6, 9, 10};
			ShowArray(Array);
			Console.WriteLine();
			Console.Write("Выберите метод(BubbleSort(1), ShakerSort(2), Find(3), BinarySearch(4),5): ");
			String SelectSort = Console.ReadLine();

			switch ( SelectSort )
			{
				case "1":
					BubbleSort(Array);
					ShowArray(Array);
					break;
				case "2":
					ShakerSort(Array);
					ShowArray(Array);
					break;
				case "3":
					Find(Array);
					ShowArray(Array);
					break;
				case "4":
					ShakerSort(Array);
					Console.Write("Введите число для поиска: ");
					String K = Console.ReadLine();
					int key = Convert.ToInt32(K);
					int result;
					result = BinarySearch_Rec(Array, key, Array[0], Array[Array.Length - 1]);
					ShowArray(Array);
					Console.WriteLine();
					Console.WriteLine(result);
					break;
				case "5":
					artem();
					break;
				default:
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Метод не найден");
					Console.ResetColor();
					Main();
					break;
			}
			Console.ReadLine();
			Main();
		}

		static Random rand = new Random();
		private static void artem()
		{
			//Thread.Sleep(1);
			Console.BackgroundColor = ( ConsoleColor )rand.Next(0, 15);
			Console.ForegroundColor = ( ConsoleColor )rand.Next(0, 15);
			Console.Write(' ');
			Task.Factory.StartNew(artem);
		}

		static void BubbleSort(int[] Array)
		{



			Console.WriteLine();
			for ( int j = Array.Length - 1; j > 0; j-- )
			{
				for ( int i = 0; i < j; i++ )
				{
					if ( Array[i] > Array[i + 1] )
					{
						SwapElement(Array, i, i + 1);
					}
				}
			}


		}

		private static void SwapElement(int[] Array, int i1, int i2)
		{
			int a = Array[i1];
			Array[i1] = Array[i2];
			Array[i2] = a;
		}

		static void ShowArray(int[] Array)
		{
			for ( int i = 0; i < Array.Length; i++ )
			{
				Console.Write(Array[i] + " ");
			}
		}

		static void ShakerSort(int[] Array2)
		{

			int Left = 0;
			int Right = Array2.Length - 1;
			while ( Left < Right )
			{
				for ( int i = Left; i < Right; i++ )
				{
					if ( Array2[i] > Array2[i + 1] )
					{
						SwapElement(Array2, i, i + 1);
					}
				}
				Right--;
				for ( int i = Right; i > Left; i-- )
				{
					if ( Array2[i] < Array2[i - 1] )
					{
						SwapElement(Array2, i, i - 1);
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
			for ( int i = 0; i < Array.Length; i++ )
			{
				if ( Array[i] == s )
				{
					Console.WriteLine("Индекс числа: " + ( i + 1 ));
					return;
				}

			}
			Console.WriteLine("Такого числа нет");
		}

		static int BinarySearch_Rec(int[] array, int key, int left, int right)
		{
			int mid = left + (right - left) / 2;

			if ( left >= right )
				return -( 1 + left );

			if ( array[mid] == key )
				return mid;

			else if ( array[mid] > key )
				return BinarySearch_Rec(array, key, left, mid);
			else
				return BinarySearch_Rec(array, key, mid + 1, right);
		}
	}
}
