using CommonModel.Models;

namespace ChainOfResponsibilityPattern.Interfaces
{
    public interface IPaymentService
    {
        void Deposit(Member member, decimal amount);

        void Withdraw(Member member, decimal amount);
    }
}