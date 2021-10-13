using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class BridgeDesignPattern
    {
    }

    abstract class MessageSenderBase
    {
        public void Save()
        {
            Console.WriteLine("Message saved!");
        }

        public abstract void Send(Body body);

    }
    
    class Body
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }

    class MailSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via MailSender", body);
        }
    }

    class FaxSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via FaxSender", body);
        }
    }

    class CustomerManager_BC
    {
        public MessageSenderBase MessageSenderBase { get; set; }
        public void UpdateCustomer()
        {
            MessageSenderBase.Send(new Body());
            Console.WriteLine("Customer updated");
        }
    }
}
