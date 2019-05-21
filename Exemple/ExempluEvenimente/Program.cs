using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
	class Program
	{
		static void Main(string[] args)
		{
			Telefon telefonulMeu = new Telefon();
			telefonulMeu.Suna += TelefonulMeu_Suna;

			telefonulMeu.Apeleaza("+404235234");

			Console.WriteLine("Press any key to close!");
			Console.ReadKey();
		}

		private static void TelefonulMeu_Suna(string numar)
		{
			Console.WriteLine($"Sunt apelat de catre: {numar}");
		}



		//FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
		//fileSystemWatcher.Path = "C:\\Test";

		//fileSystemWatcher.Created += FileCreated;
		//fileSystemWatcher.Renamed += FileRenamed;
		//fileSystemWatcher.Renamed -= FileRenamed;

		//fileSystemWatcher.EnableRaisingEvents = true;

		//private static void FileRenamed(object sender, RenamedEventArgs e)
		//{
		//	Console.WriteLine($"Renamed: {e.Name} from {e.OldName}");
		//}

		//static void FileCreated(object sender, FileSystemEventArgs e)
		//{
		//	Console.WriteLine($"Created: {e.Name}");
		//}

	}
}
