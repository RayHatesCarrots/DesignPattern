using System;
using ObserverPattern.Interfaces;
using ObserverPattern.Models;

namespace ObserverPattern.Services
{
    public class BoUserEmailService : IEmailNotificationObserver
    {
        public void SendEmail(Member member)
        {
            //TODO: Send email to Back Office user
            Console.WriteLine($"Send email to BO admin, {member.MemberCode}'s balance has been changed, current balance: {member.Balance}");
        }
    }
}