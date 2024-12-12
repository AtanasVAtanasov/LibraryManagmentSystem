namespace LibraryMangmentSystem.Members
{
    public abstract class Member
    {
        public string Name { get; set; }
        public int MemberID { get; set; }
        public string MembershipType { get; set; }
        public int BorrowedBooks { get; private set; }
        public int BorrowingLimit;

        protected Member(string name, int memberId, string membershipType, int borrowingLimit)
        {
            Name = name;
            MemberID = memberId;
            MembershipType = membershipType;
            BorrowingLimit = borrowingLimit;
        }

        public bool CanBorrow()
        {
            return BorrowedBooks < BorrowingLimit;
        }

        public void BorrowBook()
        {
            if (CanBorrow())
                BorrowedBooks++;
            else
                throw new InvalidOperationException("Borrowing limit reached.");
        }

        public void ReturnBook()
        {
            if (BorrowedBooks > 0)
                BorrowedBooks--;
            else
                throw new InvalidOperationException("No books to return.");
        }
        public void DisplayMemberInfo()
        {
            Console.WriteLine($"" +
                $"Name: {Name}\n" +
                $"MemberID: {MemberID}\n" +
                $"Membership Type: {MembershipType}\n" +
                $"BorrowedBooks: {BorrowedBooks}\n");
        }
    }
}
