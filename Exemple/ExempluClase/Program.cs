using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
	class Program
	{
		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			Console.WriteLine("Introduceti raza cercului:");
			double razaCerc = double.Parse(Console.ReadLine());

			Console.WriteLine("Introduceti latura triunghiului echilateral:");
			double laturaTriunghi = double.Parse(Console.ReadLine());

			Console.WriteLine("Perimetrul cercului este:");
			Console.WriteLine(Cerc.CalculeazaPerimetru(razaCerc));

			Triunghi triunghi = new Triunghi();
			Console.WriteLine("Perimetrul triunghiului este:");
			triunghi.CalculeazaPerimetru(laturaTriunghi);
			Console.WriteLine(triunghi.Perimetru);

			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
