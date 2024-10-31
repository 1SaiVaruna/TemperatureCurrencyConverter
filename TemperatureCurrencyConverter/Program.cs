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
		}

	}
}

