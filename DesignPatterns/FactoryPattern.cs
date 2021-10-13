using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
	class FactoryPattern
	{
		public class LoggerFactory : ILoggerFactory
		{
			public ILogger CreateLogger()
			{
				// Business to decide factory. Fabrikanın nasıl bir log üreteceğine karar veririz.
				return new EdLogger();
			}
		}

		public class FileLoggerFactory : ILoggerFactory
		{
			public ILogger CreateLogger()
			{
				// Business to decide factory. Fabrikanın nasıl bir log üreteceğine karar veririz.
				return new EdLogger();
			}
		}

		public interface ILoggerFactory
		{
			ILogger CreateLogger();
		}


		public interface ILogger
		{
			void Log();
		}

		public class EdLogger : ILogger
		{
			public void Log()
			{
				Console.WriteLine("Logged with EdLogger");
			}
		}

		public class CustomerManager
		{
			private ILoggerFactory _loggerFactory;

            public CustomerManager(ILoggerFactory loggerFactory)
            {
				_loggerFactory = loggerFactory;
            }

			public void Save()
            {
				Console.WriteLine("Saved!");
				ILogger logger = _loggerFactory.CreateLogger();
				logger.Log();
			}
		}
	}
}
