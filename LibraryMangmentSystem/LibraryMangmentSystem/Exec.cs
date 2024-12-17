using LibraryMangmentSystem.Library;
using LibraryMangmentSystem.Members;

public class Exec
{
    public static void Main()
    {
        Library library = new Library();

        library.AddBook(new Book("It", "Steven King", "12345", 3));
        library.AddBook(new Book("Don Quixote", "Miguel de Cervantes ", "67890", 2));

        Member alice = new StudentMember("Atanas Atanasov", 1);
        Member bob = new StaffMember("Pavel Pavlov", 2);

        library.AddMember(alice);
        library.AddMember(bob);

        library.BorrowBook(1, "12345"); 
        library.BorrowBook(1, "67890"); 
        library.BorrowBook(2, "67890"); 

        library.ReturnBook(2, "67890"); 

        Console.WriteLine();
        library.DisplayLibraryBooks();

        Console.WriteLine();
        library.DisplayLibraryMembers();
    }
}