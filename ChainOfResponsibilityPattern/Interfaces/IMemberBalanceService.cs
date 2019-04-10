using CommonModel.Models;

namespace ChainOfResponsibilityPattern.Interfaces
{
    public interface IMemberBalanceService
    {
        bool IncreaseBalance(Member member, decimal amount);

        bool DecreaseBalance(Member member, decimal amount);
    }
}