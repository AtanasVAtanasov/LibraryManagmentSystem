namespace LibraryMangmentSystem.Members
{
    public class StudentMember : Member
    {
        public StudentMember(string name, int memberId, int borrowingLimit = 5)
        : base(name, memberId, "Student", borrowingLimit)
        {
        }
    }
}
