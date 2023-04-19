namespace Sliit.MTIT_Assignment02.Members.Models
{
    public class Members
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? MembershipType { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
        public bool IsMembershipActive { get; set; }
        public decimal MembershipFee { get; set; }
    }
}
