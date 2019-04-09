using CommonModel.Models;

namespace ObserverPattern.Interfaces
{
    public interface IEmailNotificationSubject
    {
        void RegisterEmailNotificationObserver(IEmailNotificationObserver iEmailNotificationObserver);

        void RemoveEmailNotificationObserver(IEmailNotificationObserver iEmailNotificationObserver);

        void NotifyToSendEmail(Member member);
    }
}