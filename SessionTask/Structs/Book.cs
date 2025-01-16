using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionTask.Structs
{
    public struct Book
    {
        public string Title { get; set; }
        public string Auther { get; set; }
        public string ISBN { get; set; }

        public Book(string _title, string _auther,string _isbn) 
        {
            Title = _title;
            Auther = _auther;
            ISBN = _isbn;
        }
    }
}
