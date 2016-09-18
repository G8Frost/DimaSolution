using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("система счисления:");

			var cc = Convert.ToInt32( Console.ReadLine());

			//Просьба ввести число
			Console.Write("Введите число: ");

			//Строка, которую ввёл пользователь
			string Input = Console.ReadLine();

			//Перевод строки в число
			int a = Convert.ToInt32(Input);

			//Стэк, в который будет записываться результат
			Stack<int> numbers = new Stack<int>();

			//Результат деления числа, введённого пользователем на 2 для перевода в двоичную систему
			int result = a;

			if (a < cc)
			{
				numbers.Push(a);
			}
			else
			{


				//Перевод в двоичную систему
				//Пока результат не = 0, будут выполняться действия:
				while ( result != 0 )
				{
					//Поиск остатка от деления
					int rest = result%cc;

					//Запись остатка в стэк
					numbers.Push(rest);

					result = result / cc;
				}
			}
			while ( numbers.Count != 0 )
			{
				//Вывод результата в консоль
				Console.Write(numbers.Pop());
			}

			Console.WriteLine();
			//Повтор метода
			Main(args);
		}
	}
}
