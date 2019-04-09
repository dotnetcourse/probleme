using FermaAnimalelor.Infrastructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaAnimalelor
{
    abstract class Animal:Object
    {
        public bool AnimalHranit { get; private set; }

        public bool AnimalAdormit { get; private set; }
        public abstract string Rasa { get; }
        protected abstract IHrana HranaPreferata { get; }
        public void Mananca(IHrana hrana)
        {
            if(hrana.Denumire == HranaPreferata.Denumire)
            {
                AnimalHranit = true;
            }
        }

        public void Doarme()
        {
            if (AnimalHranit)
            {
                AnimalAdormit = true;
            }
           
        }

        public abstract IResursa ColecteazaResurse();
    }
}
