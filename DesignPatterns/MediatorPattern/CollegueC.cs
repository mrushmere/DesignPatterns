using System;

namespace MediatorPattern
{
    public class CollegueC : Collegue
    {
        public CollegueC(Mediator mediator) : base(mediator)
        {
        }

        public override void Receive(string msg)
        {
            Console.WriteLine($"Collegue C got message {msg}");
        }

        public override void Send(string msg)
        {
            Console.WriteLine($"Collegue C sends message {msg}");
            mediator.SendMessage(msg, "C");
        }
    }
}