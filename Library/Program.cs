using Library;

List<Book> books = new List<Book>();
List<Member> members = new List<Member>();

books.Add(new Book("C# for beginners", "Bill Gates", 1234567890));
books.Add(new Book("C# for dummies", "Steve Jobs", 1001632060));

members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));

// Current books in the library
Console.WriteLine("Current books in the library:");
foreach (Book book in books)
{
    book.DisplayInfo();
}

// Current members in the library
Console.WriteLine("Current members in the library:");
foreach (Member member in members)
{
    member.DisplayInfo();
}

