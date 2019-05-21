using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
	class Program
	{
		static string animal;

		static string Animal
		{
			get
			{
				return animal;
			}
			set
			{
				if (string.IsNullOrEmpty( value.Trim()))
				{
					Console.WriteLine("Nu este un text valid.");
					return;
				}

				if (value.Length < 3)
				{
					Console.WriteLine("Prea putine caractere.");
					return;
				}

				animal = value;
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Introduceti animal:");
			Animal = Console.ReadLine();

			if (!string.IsNullOrEmpty(Animal))
			{
				Console.WriteLine("Animalul introdus este:");
				Console.WriteLine(Animal);
			}

			Console.ReadKey();
		}
	}
}
