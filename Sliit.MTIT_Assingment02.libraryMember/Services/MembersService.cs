using Sliit.MTIT_Assignment02.Members.Data;
using Sliit.MTIT_Assignment02.Members.Models;

namespace Sliit.MTIT_Assignment02.Members.Services
{
    public class MembersService : IMembersService
    {

        public List<Models.Members> GetMembers()
        {
            return MembersMockDataService.Members;
        }

        public Models.Members? GetMember(int id)
        {
            return MembersMockDataService.Members.FirstOrDefault(members => members.Id == id);
        }

        public Models.Members? AddMember(Models.Members member)
        {
            MembersMockDataService.Members.Add(member);
            return member;
        }

        public Models.Members? UpdateMember(Models.Members member)
        {
            Models.Members selectedMember = MembersMockDataService.Members.FirstOrDefault(x => x.Id == member.Id);
            if (selectedMember != null)
            {
                selectedMember.FirstName = member.FirstName;
                selectedMember.LastName = member.LastName;
                selectedMember.Email = member.Email;
                selectedMember.Phone = member.Phone;
                selectedMember.Address = member.Address;
                selectedMember.MembershipType = member.MembershipType;
                selectedMember.DateOfBirth = member.DateOfBirth;
                selectedMember.DateJoined = member.DateJoined;
                selectedMember.IsMembershipActive = member.IsMembershipActive;
                selectedMember.MembershipFee = member.MembershipFee;
                return selectedMember;
            }
            return selectedMember;
        }

        public bool? DeleteMember(int id)
        {
            Models.Members selectedMember = MembersMockDataService.Members.FirstOrDefault(x => x.Id == id);
            if (selectedMember != null)
            {
                MembersMockDataService.Members.Remove(selectedMember);
                return true;
            }
            return false;
        }

   
    }
}
