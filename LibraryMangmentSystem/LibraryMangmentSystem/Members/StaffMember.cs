namespace LibraryMangmentSystem.Members
{
    public class StaffMember : Member
    {
        public StaffMember(string name, int memberId, int borrowingLimit = 10)
        : base(name, memberId, "Staff", borrowingLimit)
        {
        }
    }
}
