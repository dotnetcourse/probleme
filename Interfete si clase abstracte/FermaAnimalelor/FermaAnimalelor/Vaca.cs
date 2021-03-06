﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FermaAnimalelor.Hrana;
using FermaAnimalelor.Infrastructura;
using FermaAnimalelor.Resurse;

namespace FermaAnimalelor
{
    class Vaca : Animal
    {
        protected override string Rasa => "Vaca";

        protected override IHrana HranaPreferata => new Fan();

        public override IResursa ColecteazaResurse()
        {
            return new Lapte();
        }
    }
}
