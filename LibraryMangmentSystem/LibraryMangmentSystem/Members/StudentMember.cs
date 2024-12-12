namespace LibraryMangmentSystem.Members
{
    public class StudentMember : Member
    {
        public StudentMember(string name, int memberId, int borrowingLimit)
        : base(name, memberId, "Student", borrowingLimit)
        {
        }
    }
}
