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
			Console.Write("Введите текст c лишними буквами: ");
			String text = Console.ReadLine();
			char[] array = text.ToCharArray();
			Queue<char> result = new Queue<char>();
			int N = array.Length;
			result.Enqueue(array[0]);
			for (int i = 1; i < N; i++)
			{
				if (array[i] != array[i - 1])
				{
					result.Enqueue(array[i]);
				}
				
			}
			Console.WriteLine(result.ToArray());
			Console.ReadLine();
			Main();
		}
	}
}
