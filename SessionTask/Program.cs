using SessionTask.Classes;
using SessionTask.Structs;

namespace SessionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book( "Backend", "Ahmed", "12345" );

            BorrowedBook borrowedBook = new BorrowedBook(10, true, book, "mahmoud", new DateTime(2024, 12, 10));

            borrowedBook.CheckOut();
            borrowedBook.ReturnItem();

            Console.WriteLine(borrowedBook.CalculateBorrowDuration());
        }
    }
}
