namespace TemperatureCurrencyConverter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();
			Console.Title = "TEMPERATURE & CURRENCY CONVERTER";
			Console.WriteLine("TEMPERATURE / CURRENCY CONVERTER");
			Console.WriteLine("---------------------------------\n");
			Console.WriteLine("- [T] TEMPERATURE CONVERTER\n");
			Console.WriteLine("- [C] CURRENCY CONVERTER\n");
			Console.WriteLine("- [X] EXIT\n");
			Console.Write("ENTER OPTION: ");
			string answer = Console.ReadLine().ToUpper();

			if (answer == "X")
			{
				break;
			}

			if (answer == "C")
			{
				Console.Clear();
				Console.WriteLine("CURRENCY CONVERTER");
				Console.WriteLine("-------------------\n");
				Console.WriteLine("- [1] POUNDS TO EUROS\n");
				Console.WriteLine("- [2] EUROS TO POUNDS\n");
				Console.Write("ENTER OPTION: ");
				string choice = Console.ReadLine();
			}
		}

	}
}

