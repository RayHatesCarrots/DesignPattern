using ObserverPattern.Models;

namespace ObserverPattern.Interfaces
{
    public interface IEmailNotificationObserver
    {
        void SendEmail(Member member);
    }
}