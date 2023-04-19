namespace Sliit.MTIT_Assignment02.Members.Services
{
    public interface IMembersService
    {
        List<Models.Members> GetMembers();
        Models.Members? GetMember(int id);
        Models.Members? AddMember(Models.Members member);
        Models.Members? UpdateMember(Models.Members member);
        bool? DeleteMember(int id);
    }
}
