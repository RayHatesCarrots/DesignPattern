using CommonModel.Models;
using ObserverPattern.Interfaces;
using System.Collections.Generic;

namespace ObserverPattern.Services
{
    public class MemberService : IEmailNotificationSubject
    {
        public List<IEmailNotificationObserver> EmailNotificationObservers;

        public MemberService()
        {
            EmailNotificationObservers = new List<IEmailNotificationObserver>();
        }

        private void UpdateBalance(Member member, decimal amount)
        {
            member.Balance += amount;
            NotifyToSendEmail(member);
        }

        public void IncreaseBalance(Member member, decimal amount)
        {
            UpdateBalance(member, amount);
        }

        public void DecreaseBalance(Member member, decimal amount)
        {
            UpdateBalance(member, -amount);
        }

        #region IEmailNotificationSubject

        public void RegisterEmailNotificationObserver(IEmailNotificationObserver iEmailNotificationObserver)
        {
            EmailNotificationObservers.Add(iEmailNotificationObserver);
        }

        public void RemoveEmailNotificationObserver(IEmailNotificationObserver iEmailNotificationObserver)
        {
            EmailNotificationObservers.Remove(iEmailNotificationObserver);
        }

        public void NotifyToSendEmail(Member member)
        {
            foreach (var emailNotificationObserver in EmailNotificationObservers)
            {
                emailNotificationObserver.SendEmail(member);
            }
        }

        #endregion IEmailNotificationSubject
    }
}