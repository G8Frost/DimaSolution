using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace Repeat
{
	class Program
	{
		static void Main( string[] args )
		{
			int Result = 1;
			string Step = "Шаг : R =";
			for (int i = 2; i <= 5 ; i++)
			{
				Result = Result + i;
				Console.WriteLine(i - 1 + Step + Result);
			}
			Console.ReadLine();
		}
	}
}
