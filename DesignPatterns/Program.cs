using System;
using static DesignPatterns.FactoryPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // FACTORY PATTERN USAGE
            //CustomerManager customerManager = new CustomerManager(new LoggerFactory());
            //customerManager.Save();

            //Console.ReadLine();

            // COMPOSİTE PATTERN USAGE
            //Employee_CP omer = new Employee_CP { Name = "Ömer Ekinci" };
            //Employee_CP yusuf = new Employee_CP { Name = "Yusuf Ekinci" };

            //omer.AddSubordinate(yusuf);

            //Employee_CP elif = new Employee_CP { Name = "Elif Daldaban" };
            //omer.AddSubordinate(elif);

            //Employee_CP engin = new Employee_CP { Name = "Engin Cindoruk" };
            //yusuf.AddSubordinate(engin);

            //foreach (Employee_CP manager in omer)
            //{
            //    Console.WriteLine("  {0}",manager.Name);
            //    foreach (Employee_CP employee in manager)
            //    {
            //        Console.WriteLine("    {0}",employee.Name);
            //    }
            //}

            //Console.ReadLine();

            // MEDIATOR DESIGN PATTERN
            Mediator mediator = new Mediator();
            Teacher teacher = new Teacher(mediator);
            mediator.Teacher = teacher;
        }
    }
}
