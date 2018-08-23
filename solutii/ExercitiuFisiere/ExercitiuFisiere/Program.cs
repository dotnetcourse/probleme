using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiuFisiere
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definitia problemei:
            // Creati un program consola care sa citeasca un fisier, care contine doar 2 linii, pe prima linie sunt numere separate prin spatiu, 
            // pe a doua linie poate sa fie orice text. Programul trebuie sa citeasca prima linie si sa adune toate numerele separate prin spatiu, 
            // rezultatul sa fie scris intr-un fisier nou, pe prima linie. A doua linie din primul fisier, trebuie scris verbatim in fisierul de iesire, pe a doua linie.

            // Ex.de fisier de intrare (trebuie sa fie prezent in locatia c:\temp\fisier_intraer.txt):
            // 123 321 111
            // text 123###$$

            // Ex.de fisier de iesire:
            // 555
            // text 123###$$ 

            //deschidem fisierul pentru citire
            FileStream fsread = File.Open(@"c:\temp\fisier_intrare.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sr = new StreamReader(fsread);

            //citim prima linie
            string line = sr.ReadLine();

            //trebuie sa impartim linia pe valori individuale, separate prin spatiu
            string[] valoriString = line.Split(' ');

            //iteram prin toate valorile si le parsam in int si le adunam
            int suma = 0;
            foreach (string value in valoriString)
            {
                int numeric = int.Parse(value);
                suma += numeric;
            }

            //deschidem fisierul pentru scriere
            FileStream fswrite = File.Open(@"c:\temp\fiser_iesire.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
            StreamWriter sw = new StreamWriter(fswrite);

            //scriem suma in fisierul de iesire
            sw.WriteLine(suma);

            //citim a doua linie din fisierul de intrare
            string line2 = sr.ReadLine();

            //scriem a doua linie in fisierul de iesire
            sw.WriteLine(line2);

            //facem flush la StreamWriter pentru a ne asigura ca datele sunt scrise in fisier
            sw.Flush();

            //inchidem fisierul de intrare si iesire
            fswrite.Close();
            fsread.Close();

            Console.WriteLine("Program a terminat executia. Apasati tasta Enter pentru a iesi din program.");
            Console.ReadLine();
        }
    }
}
