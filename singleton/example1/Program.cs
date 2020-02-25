using System;

namespace example1
{
	// Классическая реализация
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Singleton.GetInstance().GetMassage());
			Console.ReadLine();
		}
	}

	class Singleton
	{
		private static Singleton _instance;

		private Singleton()
		{ }

		public static Singleton GetInstance()
		{
			return _instance ?? (_instance = new Singleton());
		}

		public string GetMassage()
		{
			return "Hello World!";
		}
	}
}
