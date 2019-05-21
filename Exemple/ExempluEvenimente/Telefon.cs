using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
	class Telefon
	{
		public delegate void SunaDetalii(string numar);

		public event SunaDetalii Suna;

		public void Apeleaza(string numar)
		{
			if (Suna != null)
			{
				Suna(numar);
			}
		}
	}
}
