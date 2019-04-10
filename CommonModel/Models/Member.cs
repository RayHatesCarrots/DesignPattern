using CommonModel.Enums;

namespace CommonModel.Models
{
    public class Member
    {
        public string MemberCode { get; set; }

        public string Email { get; set; }

        public decimal Balance { get; set; }

        public decimal ChurnValue { get; set; }

        public MemberStatus Status { get; set; }

        public Member(string memberCode, string email, decimal balance = 0, decimal churnValue = 0)
        {
            MemberCode = memberCode;
            Email = email;
            Balance = balance;
            ChurnValue = churnValue;
            Status = MemberStatus.Active;
        }
    }
}