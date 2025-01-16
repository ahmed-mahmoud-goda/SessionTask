using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionTask.Classes
{
    public class LibraryItem
    {
        public int ItemId { get; set; }
        public bool IsAvailable { get; set; }

        public LibraryItem(int _itemId,bool _isAvailable)
        {
            ItemId = _itemId;
            IsAvailable = _isAvailable;
        } 
        
        public void CheckOut()
        {
            IsAvailable = false;
            Console.WriteLine("item checked out");
        }
        public void ReturnItem()
        {
            IsAvailable = true;
            Console.WriteLine("item returned");
        }
    }
}
