using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraSpaces
{
	class Program
	{
		static void Main()
		{
			Console.Write("Введите текст c лишними буквами р: ");
			String Text = Console.ReadLine();

			char[] Array = Text.ToCharArray();
			Queue<char> Result = new Queue<char>();
			int N = Array.Length;
			for ( int i = 0; i < N; i++ )
			{
				if ( Array[i] != 'р' )
				{
					Result.Enqueue(Array[i]);
				}
				else if ( Array[i - 1] != 'р' )
				{
					Result.Enqueue(Array[i]);
				}
			}
			Console.WriteLine(Result.ToArray());
			Console.ReadLine();
		}
	}
}
