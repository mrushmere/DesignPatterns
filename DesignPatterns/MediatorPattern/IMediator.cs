using System.Net.Mail;

namespace MediatorPattern
{
    public interface IMediator
    {
        void SendMessage(string msg, string collegue);
    }
}
