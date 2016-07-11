using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "Факториал" );
			Console.Write( "Введите число: " );
			String strF = Console.ReadLine();
			int F = Convert.ToInt32(strF);
			int Result = 1;
			for (int i = 2; i <= F; i++) 
			{
				Result = Result * i;
			}
			Console.WriteLine( "Ответ: " + Result );
			Main(args);
		}
	}
}
