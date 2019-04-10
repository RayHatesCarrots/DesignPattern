using System;
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
            var paymentService = new PaymentService(50000, memberBalanceService);

            var memberA = new Member("memberA", "memberA@email.com");
            var memberB = new Member("memberB", "memberB@email.com", 50, 50);
            var memberC = new Member("memberC", "memberC@email.com", 100, 25);

            paymentService.Deposit(memberA, 10);
            paymentService.Withdraw(memberB, 25);
            paymentService.Withdraw(memberC, 75);

            Console.WriteLine("=========== Chain Of Responsibility Pattern(END) ===========");

            Console.ReadLine();
        }
    }
}
