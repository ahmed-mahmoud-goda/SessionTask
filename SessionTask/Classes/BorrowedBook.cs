using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SessionTask.Structs;

namespace SessionTask.Classes
{
    public class BorrowedBook : LibraryItem
    {
        public Book BookDetails { get; set; }
        public string? BorrowerName { get; set; }
        public DateTime BorrowedDate { get; set; }

        public BorrowedBook(int _itemId, bool _isAvailable, Book _book, string _borrowerName, DateTime _dateTime) :base(_itemId,_isAvailable) 
        {
            BookDetails = _book;
            BorrowerName = _borrowerName;
            BorrowedDate = _dateTime;
        }

        public int CalculateBorrowDuration()
        {
            return (DateTime.Now - BorrowedDate).Days;
        }
    }
}
