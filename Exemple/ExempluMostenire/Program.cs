using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempluMostenire
{
	class Program
	{
		static void Main(string[] args)
		{
			Radiou radiou = new Radiou("lampi");
			Radiou radiouModern = new Radiou("tranzistori");


			Casetofon casetofon = new Casetofon("tranzistori", 25);
			


			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
