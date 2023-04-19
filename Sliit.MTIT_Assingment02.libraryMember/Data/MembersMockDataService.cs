namespace Sliit.MTIT_Assignment02.Members.Data
{
    public class MembersMockDataService
    {
        public static List<Models.Members> Members = new List<Models.Members>()
                {
                new Models.Members
                {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "johndoe@example.com",
                Phone = "123-456-7890",
                Address = "123 Main St",
                MembershipType = "Gold",
                DateOfBirth = new DateTime(1995, 10, 15),
                DateJoined = new DateTime(2020, 01, 01),
                IsMembershipActive = true,
                MembershipFee = 100.00m
                },
                new Models.Members
                {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe",
                Email = "janedoe@example.com",
                Phone = "123-456-7890",
                Address = "456 Second Ave",
                MembershipType = "Silver",
                DateOfBirth = new DateTime(1998, 05, 20),
                DateJoined = new DateTime(2021, 03, 15),
                IsMembershipActive = true,
                MembershipFee = 50.00m
                },
                new Models.Members
                {
                Id = 3,
                FirstName = "Bob",
                LastName = "Smith",
                Email = "bobsmith@example.com",
                Phone = "123-456-7890",
                Address = "789 Third St",
                MembershipType = "Bronze",
                DateOfBirth = new DateTime(1990, 01, 01),
                DateJoined = new DateTime(2018, 11, 01),
                IsMembershipActive = false,
                MembershipFee = 0.00m
                }
                };

        internal static Models.Members? FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
