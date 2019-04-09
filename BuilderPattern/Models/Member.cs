namespace BuilderPattern.Models
{
    public class Member
    {
        public string MemberCode { get; set; }
        public decimal Balance { get; set; }

        public Member()
        {
        }

        public Member(string memberCode, decimal balance)
        {
            MemberCode = memberCode;
            Balance = balance;
        }
    }
}