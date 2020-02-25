using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace example2
{
	class Program
	{
		static void Main(string[] args)
		{
			Multi();
			//Single();
		}

		public static void Multi()
		{
			(new Thread(() =>
			{
				Car car = new Car();
				car.Launch("Xenon");
				Console.WriteLine(car.Headlights.Type);
			})).Start();

			Car car1 = new Car();
			car1.Launch("Halogen");
			Console.WriteLine(car1.Headlights.Type);
			Console.ReadLine();
		}

		public static void Single()
		{
			Car car = new Car();
			car.Launch("Xenon");
			Console.WriteLine(car.Headlights.Type);

			// Не сможем поменять тип так как уже существует объект  
			car.Headlights = Headlights.GetInstance("Halogen");
			Console.WriteLine(car.Headlights.Type);

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

		protected Headlights(string type)
		{
			Type = type;
		}

		public static Headlights GetInstance(string type = "")
		{
			return _instance ?? (_instance = new Headlights(type));
		}
	}
}
