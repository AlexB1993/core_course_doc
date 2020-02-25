using System;
using System.Threading;

namespace example4
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine(Singleton.Text);
			//Console.WriteLine(SingletonL.Text);
			singleton_m();
			//singleton_ml();
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
		public static void singleton_ml()
		{
			(new Thread(() =>
			{
				SingletonL singleton1 = SingletonL.GetInstance();
				Console.WriteLine(singleton1.Name);
			})).Start();

			SingletonL singleton2 = SingletonL.GetInstance();
			Console.WriteLine(singleton2.Name);
			Console.ReadLine();
		}
	}


	public class Singleton
	{
		public string Date { get; private set; }
		public static string Text = "Hello";
		private Singleton()
		{
			Console.WriteLine($"Singleton ctor {DateTime.Now.TimeOfDay}");
			Date = DateTime.Now.TimeOfDay.ToString();
		}

		public static Singleton GetInstance()
		{
			Console.WriteLine($"GetInstance {DateTime.Now.TimeOfDay}");
			Thread.Sleep(500);
			return Nested.Instance;
		}

		private class Nested
		{
			static Nested() { }
			internal static readonly Singleton Instance = new Singleton();
		}
	}

	// Реализация через класс Lazy<T>

	public class SingletonL
	{
		public static string Text = "Hello";
		private static readonly Lazy<SingletonL> lazy =
			new Lazy<SingletonL>(() => new SingletonL());

		public string Name { get; private set; }

		private SingletonL()
		{
			Console.WriteLine($"Singleton ctor {DateTime.Now.TimeOfDay}");
			Name = Guid.NewGuid().ToString();
		}

		public static SingletonL GetInstance()
		{
			Console.WriteLine($"GetInstance {DateTime.Now.TimeOfDay}");
			return lazy.Value;
		}
	}
}
