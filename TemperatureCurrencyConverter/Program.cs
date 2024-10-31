namespace TemperatureCurrencyConverter
{
	internal class Program
	{
		static void Main(string[] args)
		{

			while (true)
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

					if (choice == "1")
					{
						Console.Clear();
						Console.WriteLine("CURRENCY CONVERTER - POUNDS TO EUROS");
						Console.WriteLine("-----------------------\n");
						Console.Write("ENTER AMOUNT IN BRITISH POUNDS: ");
						float pounds = float.Parse(Console.ReadLine());

						float euros = pounds * 1.16f;
						Console.WriteLine("\nEUROS: " + euros.ToString("0.00"));
					}
					else if (choice == "2")
					{
						Console.Clear();
						Console.WriteLine("CURRENCY CONVERTER - EUROS TO POUNDS");
						Console.WriteLine("-----------------------\n");
						Console.Write("ENTER AMOUNT IN EUROS: ");
						float euros = float.Parse(Console.ReadLine());

						float pounds = euros / 1.16f;
						Console.WriteLine("\nBRITISH POUNDS: " + pounds.ToString("0.00"));
					}
				}

				else if (answer == "T")
				{
					Console.Clear();
					Console.WriteLine("TEMPERATURE CONVERTER");
					Console.WriteLine("-------------------\n");
					Console.WriteLine("- [1] CELSIUS TO FAHRENHEIT\n");
					Console.WriteLine("- [2] FAHRENHEIT TO CELSIUS\n");
					Console.Write("ENTER OPTION: ");
					string choice = Console.ReadLine();

					if (choice == "1")
					{
						Console.Clear();
						Console.WriteLine("TEMPERATURE CONVERTER - CELSIUS TO FAHRENHEIT");
						Console.WriteLine("-------------------\n");
						Console.Write("ENTER AMOUNT IN CELSIUS: ");
						float celsius = float.Parse(Console.ReadLine());

						float fahrenheit = celsius * 1.8f + 32f;
						Console.WriteLine("\nFAHRENHEIT: " + fahrenheit);
					}
					else if (choice == "2")
					{
						Console.Clear();
						Console.WriteLine("TEMPERATURE CONVERTER - FAHRENHEIT TO CELSIUS");
						Console.WriteLine("-------------------\n");
						Console.Write("ENTER AMOUNT IN FAHRENHEIT: ");
						float fahrenheit = float.Parse(Console.ReadLine());

						float celsius = (fahrenheit - 32f) / 1.8f;
						Console.WriteLine("\nCELSIUS: " + celsius);
					}
				}

				else
				{
					Console.WriteLine("\nINVALID OPTION. TRY AGAIN");
				}

				Console.WriteLine();
				Console.WriteLine("PRESS ANY KEY TO RETURN TO MAIN MENU...");
				Console.ReadKey();
			}
		}
	}
}

