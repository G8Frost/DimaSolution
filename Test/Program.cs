using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Program
	{
		static void Main( string[] args )
		{
			var Dima = new People();
			Dima.Age = 12;

			Console.WriteLine(Dima.Age);

			Console.ReadLine();
		}
	}
}
