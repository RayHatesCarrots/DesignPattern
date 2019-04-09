using ObserverPattern.Enums;

namespace ObserverPattern.Models
{
    public class Member
    {
        public string MemberCode { get; set; }

        public string Email { get; set; }

        public decimal Balance { get; set; }

        public MemberStatus Status { get; set; }

        public Member(string memberCode, string email)
        {
            MemberCode = memberCode;
            Email = email;
            Balance = 0;
            Status = MemberStatus.Active;
        }
    }
}