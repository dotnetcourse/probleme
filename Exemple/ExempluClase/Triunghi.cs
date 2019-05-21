using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
	class Triunghi
	{
		double perimetru;

		public double Perimetru
		{
			get { return perimetru; }
		}

		public void CalculeazaPerimetru(double latura)
		{
			perimetru = latura * 3;
		}
	}
}
