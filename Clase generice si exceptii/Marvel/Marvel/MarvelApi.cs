using MarvelAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelApp
{
	class MarvelApi
	{
		private Marvel marvelApi;

		public MarvelApi()
		{
			marvelApi = new Marvel("c886fa14b8458ab2c899c25c0e282baf", "a7e93dfcc905218264a44cea885dea95fb0e92a3");
			
		}

		public IEnumerable<Character> GetCharacters(int limit, int offset)
		{
			var a = marvelApi.GetCharacters(Limit: limit, Offset: offset);

			return a;
		}

		public IEnumerable<Series> GetSeries(int limit, int offset)
		{
			var a = marvelApi.GetSeries(Limit: limit, Offset: offset);

			return a;
		}
	}
}
