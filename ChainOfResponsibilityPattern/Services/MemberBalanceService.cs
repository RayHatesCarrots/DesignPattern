using ChainOfResponsibilityPattern.Interfaces;
using CommonModel.Models;
using System;

namespace ChainOfResponsibilityPattern.Services
{
    public class MemberBalanceService : IMemberBalanceService
    {
        private readonly IMemberChurnService _iMemberChurnService;

        public MemberBalanceService(IMemberChurnService iMemberChurnService)
        {
            _iMemberChurnService = iMemberChurnService;
        }

        public bool IncreaseBalance(Member member, decimal amount)
        {
            if (_iMemberChurnService.IncreaseChurnValue(member, amount))
            {
                member.Balance += amount;
                Console.WriteLine($"{member.MemberCode}'s current balance: {member.Balance}");

                return true;
            }

            Console.WriteLine($"{member.MemberCode} increase balance fail");

            return false;
        }

        public bool DecreaseBalance(Member member, decimal amount)
        {
            if (member.Balance > amount)
            {
                member.Balance -= amount;
                Console.WriteLine($"{member.MemberCode}'s current balance: {member.Balance}");

                return true;
            }

            Console.WriteLine($"{member.MemberCode} decrease balance fail");

            return false;
        }
    }
}