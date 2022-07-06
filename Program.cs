using System;

namespace HelloWorld
{
	internal class Program {
		public static void Main(string[] args)
		{
			Console.WriteLine("Type NAME:");
			var name = Console.ReadLine();
			if ((name == "NAME") || (name == "NAME:")) {
				Console.WriteLine("You're way to literal. Quit being a numpty and try again.");
				Console.WriteLine("Type your name. And don't you dare type \"your name\" you numpty.");
				name = Console.ReadLine();
				if (name == "your name") {Console.WriteLine("..... Fine. You win.");}
			}
			Console.WriteLine("Hello, {0}.", name);
			Console.WriteLine("Press the ANY key to continue...");
			Console.ReadKey();
		}	
	}
}
