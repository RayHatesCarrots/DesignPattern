using ObserverPattern.Interfaces;
using ObserverPattern.Models;
using System;

namespace ObserverPattern.Services
{
    public class MemberEmailService : IEmailNotificationObserver
    {
        public void SendEmail(Member member)
        {
            //TODO: Send email to member
            Console.WriteLine($"Send email to {member.MemberCode}, email: {member.Email}, balance: {member.Balance}");
        }
    }

    public class BoUserEmailService : IEmailNotificationObserver
    {
        public void SendEmail(Member member)
        {
            //TODO: Send email to Back Office user
            Console.WriteLine($"Send email to BO admin, {member.MemberCode}'s balance has been changed, current balance: {member.Balance}");
        }
    }
}