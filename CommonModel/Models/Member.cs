using CommonModel.Enums;

namespace CommonModel.Models
{
    public class Member
    {
        public string MemberCode { get; set; }

        public string Email { get; set; }

        public decimal Balance { get; set; }

        public MemberStatus Status { get; set; }

        public Member(string memberCode, string email, decimal amount = 0)
        {
            MemberCode = memberCode;
            Email = email;
            Balance = amount;
            Status = MemberStatus.Active;
        }
    }
}