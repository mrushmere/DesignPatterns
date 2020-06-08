using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class CollegueB : Collegue
    {
        public CollegueB(Mediator mediator) : base(mediator)
        {
        }

        public override void Receive(string msg)
        {
            Console.WriteLine($"Collegue B got message {msg}");
        }

        public override void Send(string msg)
        {
            Console.WriteLine($"Collegue B sends message {msg}");
            mediator.SendMessage(msg, "B");
        }
    }
}
