using System;
using System.Threading;

namespace example3
{
	class Program
	{
		static void Main(string[] args)
		{
			//Multi();
			singleton_m();
		}
		public static void Multi()
		{
			for (int i = 0; i < 1000; i++)
			{
				(new Thread(() =>
				{
					Car car = new Car();
					car.Launch("Xenon");
					Console.WriteLine(car.Headlights.Type);
				})).Start();
			}
		

			Car car1 = new Car();
			car1.Launch("Halogen");
			Console.WriteLine(car1.Headlights.Type);
			Console.ReadLine();
		}


		public static void singleton_m()
		{
			(new Thread(() =>
			{
				Singleton singleton1 = Singleton.GetInstance();
				Console.WriteLine(singleton1.Date);
			})).Start();

			Singleton singleton2 = Singleton.GetInstance();
			Console.WriteLine(singleton2.Date);
			Console.ReadLine();
		}

	}

	class Car
	{
		public Headlights Headlights { get; set; }

		public void Launch(string headlightType)
		{
			Headlights = Headlights.GetInstance(headlightType);
		}
	}

	class Headlights
	{
		private static Headlights _instance;

		public string Type { get; }

		private static object _syncRoot = new Object();

		protected Headlights(string type)
		{
			Type = type;
		}

		public static Headlights GetInstance(string type = "")
		{
			lock (_syncRoot)
			{
				if (_instance == null)
					_instance = new Headlights(type);
			}

			return _instance;
		}
	}

	// реализация без lock за счет хуков языка 
	public class Singleton
	{
		private static readonly Singleton instance = new Singleton();

		public string Date { get; private set; }

		private Singleton()
		{
			Console.WriteLine($"constr {DateTime.Now.TimeOfDay.ToString()}");
			Date = System.DateTime.Now.TimeOfDay.ToString();
		}

		public static Singleton GetInstance()
		{
			return instance;
		}
	}
}
