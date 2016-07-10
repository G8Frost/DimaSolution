using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "ax+b=0" );
			Console.Write( "Введите a: " );
			String strA = Console.ReadLine();
			Console.Write( "Введите b: " );
			String strB = Console.ReadLine();
			Double a = Convert.ToDouble(strA);
			Double b = Convert.ToDouble(strB);
			if ( a == 0 && b == 0 )
			{
				Console.WriteLine( "Уравнение имеет бесконечное множество решений" );
			}
			if (a == 0 && b != 0)
			{
				Console.WriteLine("Уравнение не имеет решений");
			}
			if (a != 0)
			{
				Console.WriteLine( "x= " + ( -b / a ) );
			}
			
			Main( args );
		}
	}
}
