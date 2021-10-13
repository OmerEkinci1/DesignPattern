using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class FacadeDesignPattern
    {
    }

    interface ILogging
    {
        void Log();
    }

    interface ICaching
    {
        void Cache();
    }

    interface IAuthorize
    {
        void CheckUser();
    }

    class Logging_FacadePattern : ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    class Caching_FacadePattern : ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    class Authorize : IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("Authorize");
        }
    }

    class CustomerManager
    {
        CCC_Facade _cccFacade;
        public CustomerManager()
        {
            _cccFacade = new CCC_Facade();
        }

        public void Save()
        {
            _cccFacade.Caching.Cache();
            _cccFacade.Logging.Log();
            _cccFacade.Authorize.CheckUser();
            Console.WriteLine("Saved");
        }
    }

    class CCC_Facade
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAuthorize Authorize;

        public CCC_Facade()
        {
            Logging = new Logging_FacadePattern();
            Caching = new Caching_FacadePattern();
            Authorize = new Authorize();

        }
    }
}
