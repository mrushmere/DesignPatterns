using System.Collections.Generic;
using System.Linq;

namespace MediatorPattern
{
    public class Mediator : IMediator
    {
        public Dictionary<string, Collegue> Collegues = new Dictionary<string, Collegue>();

        public void SendMessage(string msg, string collegue)
        {
            foreach(var kvp in Collegues.Where(x => x.Key != collegue)) {
                Collegues[kvp.Key].Receive(msg);
            }           
        }
    }
}
