using CommonModel.Models;

namespace ChainOfResponsibilityPattern.Interfaces
{
    public interface IMemberChurnService
    {
        bool IncreaseChurnValue(Member member, decimal amount);

        bool DecreaseChurnValue(Member member, decimal amount);

        bool CheckChurnValue(Member member, decimal amount);
    }
}