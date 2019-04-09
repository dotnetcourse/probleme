using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaAnimalelor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intr-o ferma se afla 3 vaci, 2 oi si 5 gaini. Defineste clasele corespunzatoare
            //folosind clasele si interfetele predefinite fara a le modifica in vreun fel si 
            // afiseaza raspunsurile la cele 4 intrebari de mai jos.

            //adauga animalele in lista predefinita
            var animale = new Animal[10];

            var vaca = new Vaca();
            var vaca2 = new Vaca();
            var vaca3 = new Vaca();
            var oaie = new Oaie();
            var oaie2 = new Oaie();
            var gaina = new Gaina();
            var gaina2 = new Gaina();
            var gaina3 = new Gaina();
            var gaina4 = new Gaina();
            var gaina5 = new Gaina();


            //1. Tipareste numarul de gaini calculandul programatic


            //2. Hraneste animalele cu tipul de hrana adecvat. Tipurile de hrana vor fi definite
            // folosind IHRana si create in folderul Hrana


            //3. Colecteaza toate resursele produse de animale (oua, lapte) si afisati totalul cantitatii
            //   colectate pentru fiecare din ele.
            //   Tipurile de resurse vor fi definite folosind IResursa si vor fi puse in folderul
            //   Resurse


            //4. Pune animalele la somn. Pentru a ne asigura ca animalele sunt la somn se va 
            // verifica ca fiecare Animal este "AnimalAdormit"- proprietate disponibila pe clasa 
            // animal. 

            Console.ReadLine();
        }
    }
}
