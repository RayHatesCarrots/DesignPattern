using System;
using ChainOfResponsibilityPattern.Interfaces;
using CommonModel.Models;

namespace ChainOfResponsibilityPattern.Services
{
    public class MemberChurnService : IMemberChurnService
    {
        public bool IncreaseChurnValue(Member member, decimal amount)
        {
            member.ChurnValue += amount;
            Console.WriteLine($"{member.MemberCode}'s current churn value: {member.ChurnValue}");

            return true;
        }

        public bool DecreaseChurnValue(Member member, decimal amount)
        {
            member.ChurnValue -= amount;
            Console.WriteLine($"{member.MemberCode}'s current churn value: {member.ChurnValue}");

            return true;
        }

        public bool CheckChurnValue(Member member, decimal amount)
        {
            return (member.Balance - member.ChurnValue) >= amount;
        }
    }
}