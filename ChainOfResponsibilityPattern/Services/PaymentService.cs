using ChainOfResponsibilityPattern.Interfaces;
using CommonModel.Models;
using System;

namespace ChainOfResponsibilityPattern.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IMemberBalanceService _iMemberBalanceService;

        private decimal _companyBalance;

        public PaymentService(decimal companyBalance, IMemberBalanceService iMemberBalanceService)
        {
            _companyBalance = companyBalance;
            _iMemberBalanceService = iMemberBalanceService;
        }

        public void Deposit(Member member, decimal amount)
        {
            if (_iMemberBalanceService.IncreaseBalance(member, amount))
            {
                _companyBalance += amount;
                Console.WriteLine($"{member.MemberCode} deposit {amount}, company balance now is: {_companyBalance}");
            }
            else
            {
                Console.WriteLine($"{member.MemberCode} deposit {amount} fail, company balance now is: {_companyBalance}");
            }
        }

        public void Withdraw(Member member, decimal amount)
        {
            if (_iMemberBalanceService.DecreaseBalance(member, amount))
            {
                _companyBalance -= amount;
                Console.WriteLine($"{member.MemberCode} withdraw {amount}, company balance now is: {_companyBalance}");
            }
            else
            {
                Console.WriteLine($"{member.MemberCode} withdraw {amount} fail, company balance now is: {_companyBalance}");
            }
        }
    }
}