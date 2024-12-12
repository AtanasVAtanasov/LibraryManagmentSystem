namespace LibraryMangmentSystem.Members
{
    public class StaffMember : Member
    {
        public StaffMember(string name, int memberId, int borrowingLimit)
        : base(name, memberId, "Staff", borrowingLimit)
        {
        }
    }
}
