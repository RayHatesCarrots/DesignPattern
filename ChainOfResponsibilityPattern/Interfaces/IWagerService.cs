using System;
using System.Collections.Generic;
using System.Linq;
using CommonModel.Models;

namespace ChainOfResponsibilityPattern.Interfaces
{
    public interface IWagerService
    {
        bool PlaceBet(Member member, decimal amount, out string betId);

        bool SettleBet(Member member, string betId, decimal amount);
    }

    public class WagerService : IWagerService
    {
        private readonly IMemberBalanceService _iMemberBalanceService;
        private readonly IMemberChurnService _iMemberChurnService;

        private static Dictionary<string, string> _betIdLookup;

        public WagerService(IMemberBalanceService iMemberBalanceService, IMemberChurnService iMemberChurnService)
        {
            _iMemberBalanceService = iMemberBalanceService;
            _iMemberChurnService = iMemberChurnService;
            _betIdLookup = new Dictionary<string, string>();
        }

        public bool PlaceBet(Member member, decimal amount, out string betId)
        {
            if (_iMemberBalanceService.DecreaseBalance(member, amount) && _iMemberChurnService.DecreaseChurnValue(member, amount))
            {
                betId = Guid.NewGuid().ToString();
                _betIdLookup.Add(betId, "Open");

                Console.WriteLine($"{member.MemberCode} Place bet success, amount: {amount}, betId: {betId}");

                return true;
            }

            betId = string.Empty;
            Console.WriteLine($"{member.MemberCode} Place bet fail");

            return false;
        }

        public bool SettleBet(Member member, string betId, decimal amount)
        {
            if (_betIdLookup.Keys.Any(key => key == betId) && _iMemberBalanceService.IncreaseBalance(member, amount))
            {
                _betIdLookup[betId] = "Settled";

                Console.WriteLine($"{member.MemberCode} Settled bet success, amount: {amount}, betId: {betId}");

                return true;
            }

            Console.WriteLine($"{member.MemberCode} Settled bet fail");

            return false;
        }
    }
}