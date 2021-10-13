using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class NullObjectDesignPattern
    {
        class CustomerManager
        {
            private ILogger _logger;

            public CustomerManager(ILogger logger)
            {
                _logger = logger;
            }

            public void Save()
            {
                Console.WriteLine("Saved");
                _logger.Log();
            }
        }

        interface ILogger
        {
            void Log();
        }

        class Log4NetLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged with Log4Net");
            }
        }

        class NLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged with NLogger");
            }
        }

        class StubLogger : ILogger
        {
            private static StubLogger _stubLogger;
            private static object _lock = new object();

            private StubLogger() { }
            public static StubLogger GetLogger()
            {
                lock (_lock)
                {
                    if (_stubLogger == null)
                    {
                        _stubLogger=new StubLogger();
                    }
                }
                return _stubLogger;
            }
            public void Log()
            {
                throw new NotImplementedException();
            }
        }

        class CustomerManagerTests
        {
            public void SaveTest()
            {
                CustomerManager customerManager = new CustomerManager(new StubLogger());
                customerManager.Save();
            }
        }
    }
}
