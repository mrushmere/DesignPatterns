namespace MediatorPattern
{
    public abstract class Collegue
    {
        protected Mediator mediator;

        public Collegue(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void Send(string msg);
        public abstract void Receive(string msg);
    }
}