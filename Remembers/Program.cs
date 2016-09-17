using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remembers
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Hello, world!");
			Console.ResetColor();
			
			int b = 3;
			int c = 2;
			for (int i = 0; i <= 10; i++)
			{
				if (i == 4)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine(i + " Да");
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(i + " Нет");
			}
			}
			
			Console.ReadLine();
		}
	}
}
