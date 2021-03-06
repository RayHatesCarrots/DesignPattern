﻿using CommonModel.Models;
using ObserverPattern.Interfaces;
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
}