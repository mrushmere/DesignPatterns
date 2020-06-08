using System;

namespace MediatorPattern
{
    public class CollegueA : Collegue
    {
        public CollegueA(Mediator mediator) : base(mediator)
        {
        }

        public override void Receive(string msg)
        {
            Console.WriteLine($"Collegue A got message {msg}");
        }

        public override void Send(string msg)
        {
            Console.WriteLine($"Collegue A sends message {msg}");
            mediator.SendMessage(msg, "A");
        }
    }
}
