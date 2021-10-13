using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class ObserverDesignPattern
    {
    }

    class InventoryManager
    {
        List<Observer> _observer = new List<Observer>();
        public void Updaterice()
        {
            Console.WriteLine("Inverntory price changed");
            Notify(); // Değişiklik varsa aboneler bilgilendirilecek.
        }

        public void Attach(Observer observer)
        {
            _observer.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observer.Remove(observer);
        }

        private void Notify()
        {
            foreach (var observer in _observer)
            {
                observer.Update();
            }
        }
    }

    abstract class Observer
    {
        public abstract void Update();
    }

    class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to customer : Inventory price changed");
        }
    }

    class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to customer : Inventory price changed");
        }
    }
}
