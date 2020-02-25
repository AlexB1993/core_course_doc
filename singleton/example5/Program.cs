using System;
using System.Reflection;
using example5.Interface;

namespace example5
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine(Session.Instance.Guid);
			//Console.WriteLine(Session.Instance.Guid);
			Console.WriteLine(CacheSession.GetInstance().GetCurrentGuid());
			Console.WriteLine(CacheSession.GetInstance().GetCurrentGuid());
			Console.ReadLine();
		}
	}

	public class Singleton<T> where T : class
	{
		private static T _instance;

		protected Singleton()
		{
		}

		private static T CreateInstance()
		{
			ConstructorInfo cInfo = typeof(T).GetConstructor(
				BindingFlags.Instance | BindingFlags.NonPublic,
				null,
				new Type[0],
				new ParameterModifier[0]);

			return (T)cInfo.Invoke(null);
		}

		public static T Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = CreateInstance();
				}

				return _instance;
			}
		}
	}

	public class Session : Singleton<Session>
	{
		public Guid Guid;

		private Session()
		{
			Guid = Guid.NewGuid();
		}

		public bool IsSessionExpired()
		{
			return true;
		}

		public Guid SessionID
		{
			get { return Guid; }
		}
	}

	public class CacheSession : ISession
	{
		private readonly Guid _currentGuid;
		private CacheSession()
		{
			_currentGuid = Guid.NewGuid();
		}

		public static CacheSession GetInstance()
		{
			return Singleton<CacheSession>.Instance;
		}

		public Guid GetCurrentGuid()
		{
			return _currentGuid;
		}
	}

}
