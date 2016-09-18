using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraSpaces
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите текст: ");
			String Text = Console.ReadLine();

			char[] Array = Text.ToCharArray();
			Queue<char> Result = new Queue<char>();
			int N = Array.Length;
			for ( int i = 0; i < N; i++ )
			{
				if ( Array[i] != ' ' )
				{
					Result.Enqueue(Array[i]);
				}
				else if ( Array[i - 1] != ' ' )
				{
					Result.Enqueue(Array[i]);
				}
			}
			Console.WriteLine(Result.ToArray());

			Console.ReadLine();
		}
	}
}
