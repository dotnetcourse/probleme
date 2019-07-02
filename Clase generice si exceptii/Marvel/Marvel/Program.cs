using MarvelAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Introduceti numele caracterului:");
			string numeCaracter = Console.ReadLine();

			MarvelApi marvelApi = new MarvelApi();
			List<Character> toateCaractereleMarvel = new List<Character>();

			//obtinem primele 100 de caractere:
			var setCaractere = marvelApi.GetCharacters(100, 0);
			toateCaractereleMarvel.AddRange(setCaractere);



			//TODO: scrieti cod care sa citeasca restul caracterelor Marvel - pana cand rezultatul de la GetCharacters e mai mic de 100

			//obtinem primele 20 de serii:
			List<Series> toateSeriileMarvel = new List<Series>();
			var setSerii = marvelApi.GetSeries(100, 0);
			toateSeriileMarvel.AddRange(setSerii);
			//TODO: scrieti cod care sa citeasca restul seriilor Marvel - pana cand rezultatul de la GetSeries e mai mic de 100

			//TODO: scrieti cod care sa afiseze seriile in care apare caracterul si numarul de episoade in dreptul fiecarei serii.
			// (Nota: cand comparati numele caracterului, verificati ca acesta se contine in numele din lista de marvel, deoarece poate sa contina si alt text in nume)
			// (Nota: s-ar putea sa obtineti mai multe caractere, alegeti doar primul caracter, si afisati la consola numele asa cu l-ati obtinut de la Marvel)

			//// PARTEA 2 
			// TODO: modifcati codul sa afiseze toate caracterel gasite care contin numele indicat de utilizator

			//// PARTEA 3
			// TODO: modificati codul sa cereti de la utilizator numarul de rezultate care sa fie afisate la consola, sa se foloseasca try-catch 
			//		pentru a verifica ca textul introdus de utilizator este un numar.daca nu trece aceasta validare, sa fie interogat din nou pentru numarul de rezultate
			// TODO: daca apar erori de conectivitate sa se afiseze un mesaj relevant la utilizator




		}
	}
}
