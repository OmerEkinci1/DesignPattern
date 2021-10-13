﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class VisitorDesignPattern
    {
        class organisationalStructure
        {
            public EmployeeBase Employee;

            public organisationalStructure(EmployeeBase firstEmployee)
            {
                Employee = firstEmployee;
            }

            public void Accept(VisitorBase visitor)
            {
                Employee.Accept(visitor);
            }
        }
        abstract class EmployeeBase
        {
            public abstract void Accept(VisitorBase visitor);
            public string Name { get; set; }
            public decimal Salary { get; set; }
        }

        class Manager : EmployeeBase
        {
            public Manager()
            {
                Subordinates = new List<EmployeeBase>();
            }
            public List<EmployeeBase> Subordinates { get; set; }
            public override void Accept(VisitorBase visitor)
            {
                visitor.Visit(this);

                foreach (var employee in Subordinates)
                {
                    employee.Accept(visitor);
                }
            }
        }

        class Worker : EmployeeBase
        {
            public override void Accept(VisitorBase visitor)
            {
                visitor.Visit(this);
            }
        }

        abstract class VisitorBase
        {
            public abstract void Visit(Worker worker);
            public abstract void Visit(Manager manager);
        }

        class PayrollVisitor : VisitorBase
        {
            public override void Visit(Worker worker)
            {
                Console.WriteLine("{0} paid {1}", worker.Name, worker.Salary);
            }

            public override void Visit(Manager manager)
            {
                Console.WriteLine("{0} paid {1}", manager.Name, manager.Salary);
            }
        }

        class Payrise : VisitorBase
        {
            public override void Visit(Worker worker)
            {
                Console.WriteLine("{0} salary increased to {1}", worker.Name, worker.Salary* (decimal)1.1);
            }

            public override void Visit(Manager manager)
            {
                Console.WriteLine("{0} salary increased to {1}", manager.Name, manager.Salary * (decimal)1.2);
            }
        }
    }
}
