using LibraryMangmentSystem.Members;
using System.Xml.Linq;

namespace LibraryMangmentSystem.Library
{
    public class Library : LibraryManagment
    {
        private readonly List<Book> books = new List<Book>();
        private readonly Dictionary<int, Member> members = new Dictionary<int, Member>();

        public void AddMember(Member member)
        {
            if (!members.ContainsKey(member.MemberID))
                members[member.MemberID] = member;
        }

        public override void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Added book: \"{book.Title}\" by {book.Author}. Copies added: {book.AvailableCopies}");
        }

        public override void RemoveBook(string isbn)
        {
            Book book = books.Find(b => b.ISBN == isbn);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine($"Removed book: \"{book.Title}\".");
            }
        }

        public override void BorrowBook(int memberId, string isbn)
        {
            if (!members.ContainsKey(memberId))
            {
                Console.WriteLine("Member not found.");
                return;
            }

            Member member = members[memberId];
            Book book = books.Find(b => b.ISBN == isbn);

            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            if (!member.CanBorrow())
            {
                Console.WriteLine($"{member.Name} ({member.MembershipType}) cannot borrow more books. Limit reached.");
                return;
            }

            if (!book.BorrowBook())
            {
                Console.WriteLine($"{member.Name} ({member.MembershipType}) cannot borrow \"{book.Title}\". No copies available.");
                return;
            }

            member.BorrowBook();
            Console.WriteLine($"{member.Name} ({member.MembershipType}) borrowed \"{book.Title}\". Books borrowed: {member.BorrowedBooks}/{member.BorrowingLimit}.");
        }

        public override void ReturnBook(int memberId, string isbn)
        {
            if (!members.ContainsKey(memberId))
            {
                Console.WriteLine("Member not found.");
                return;
            }

            Member member = members[memberId];
            Book book = books.Find(b => b.ISBN == isbn);

            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            member.ReturnBook();
            book.ReturnBook();
            Console.WriteLine($"{member.Name} ({member.MembershipType}) returned \"{book.Title}\". Copies available: {book.AvailableCopies}.");
        }

        public override void DisplayLibraryBooks()
        {
            Console.WriteLine("Library Books");

            foreach (Book book in books)
            {
                book.DisplayBookInfo();
            }
        }
        public override void DisplayLibraryMembers()
        {
            Console.WriteLine("Library Members");
            foreach (Member member in members.Values)
            {
                member.DisplayMemberInfo();
            }
        }
    }
}
