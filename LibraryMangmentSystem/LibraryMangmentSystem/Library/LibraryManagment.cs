using LibraryMangmentSystem.Members;
using System.Xml.Linq;

namespace LibraryMangmentSystem.Library
{
    public abstract class LibraryManagment
    {
        public abstract void AddBook(Book book);
        public abstract void RemoveBook(string isbn);
        public abstract void BorrowBook(int memberId, string isbn);
        public abstract void ReturnBook(int memberId, string isbn);
        public abstract void DisplayLibraryBooks();
        public abstract void DisplayLibraryMembers();
    }
}
