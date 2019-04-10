using System;
using ChainOfResponsibilityPattern.Interfaces;
using ChainOfResponsibilityPattern.Services;
using CommonModel;
using CommonModel.Models;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== Chain Of Responsibility Pattern ===========");

            var memberChurnService = new MemberChurnService();
            var memberBalanceService = new MemberBalanceService(memberChurnService);
            var paymentService = new PaymentService(50000, memberBalanceService, memberChurnService);
            var wagerService = new WagerService(memberBalanceService, memberChurnService);

            var memberA = new Member("memberA", "memberA@email.com");
            var memberB = new Member("memberB", "memberB@email.com", 50, 50);
            var memberC = new Member("memberC", "memberC@email.com", 100, 25);

            paymentService.Deposit(memberA, 10);
            paymentService.Withdraw(memberB, 25);
            paymentService.Withdraw(memberC, 75);

            wagerService.PlaceBet(memberA, 1, out var wagerAbetId);
            wagerService.SettleBet(memberA, wagerAbetId, 5);

            wagerService.PlaceBet(memberB, 1, out var wagerBbetId);
            wagerService.SettleBet(memberB, wagerBbetId, 5);

            wagerService.PlaceBet(memberC, 1, out var wagerCbetId);
            wagerService.SettleBet(memberC, wagerCbetId, 5);

            Console.WriteLine("=========== Chain Of Responsibility Pattern(END) ===========");

            Console.ReadLine();
        }
    }
}
