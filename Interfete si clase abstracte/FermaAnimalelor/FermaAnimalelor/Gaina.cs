using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FermaAnimalelor.Hrana;
using FermaAnimalelor.Infrastructura;
using FermaAnimalelor.Resurse;

namespace FermaAnimalelor
{
    class Gaina : Animal
    {
        protected override string Rasa => "gaina";

        protected override IHrana HranaPreferata => new Cereale();

        public override IResursa ColecteazaResurse()
        {
            return new Oua();
        }
    }
}
