using System;
using ObserverPattern.Models;
using ObserverPattern.Services;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== Observer Pattern ===========");

            var memberService = new MemberService();
            memberService.RegisterEmailNotificationObserver(new MemberEmailService());
            memberService.RegisterEmailNotificationObserver(new BoUserEmailService());

            var memberA = new Member("memberA", "memberA@email.com");
            var memberB = new Member("memberB", "memberB@email.com");
            var memberC = new Member("memberC", "memberC@email.com");

            memberService.IncreaseBalance(memberA, 1);
            memberService.IncreaseBalance(memberB, 10);
            memberService.IncreaseBalance(memberC, 100);

            memberService.DecreaseBalance(memberC, 20);

            Console.WriteLine("=========== Observer Pattern(END) ===========");

            Console.ReadLine();
        }
    }
}
