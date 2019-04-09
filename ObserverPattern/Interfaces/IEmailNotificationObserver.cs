using CommonModel.Models;

namespace ObserverPattern.Interfaces
{
    public interface IEmailNotificationObserver
    {
        void SendEmail(Member member);
    }
}