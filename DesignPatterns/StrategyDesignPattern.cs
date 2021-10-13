using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class StrategyDesignPattern
    {
    }

    abstract class CreditCalculatorBase
    {
        public abstract void Calculate();
    }

    class Before2021CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated usign before221");
        }
    }

    class After2021CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using after2021");
        }
    }

    class CustomerManager_sp
    {
        public CreditCalculatorBase creditCalculatorBase { get; set; }
        public void SaveCredit()
        {
            Console.WriteLine("Customer manager business");
            creditCalculatorBase.Calculate();
        }
    }
}
