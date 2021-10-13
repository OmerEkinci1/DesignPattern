using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class AdapterDesignPattern
    {
    }

    class StockManager
    {
        ILogger_AdapterPattern _logger;

        public StockManager(ILogger_AdapterPattern logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            _logger.Log("User Data");
            Console.WriteLine("Saved");
        }
    }

    interface ILogger_AdapterPattern
    {
        void Log(string message);
    }

    class simpleLogger : ILogger_AdapterPattern
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged, {0}", message);
        }
    }

    // Nugetten eklendiği için dll'e dokunamıyorum. Bunu paket olarak düşünelim bu protototipte.
    class log4net 
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged, {0}", message);
        }
    }

    class log4netAdapter : ILogger_AdapterPattern
    {
        public void Log(string message)
        {
            log4net log4net = new log4net();
            log4net.Log(message);
        }
    }
}
