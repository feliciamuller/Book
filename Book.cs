using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Book
    {
        //creating fields
        public string _title;
        public string _author;
        public string _summary;

        //creating constructor and initialize the fields
        public Book(string title, string author, string summary)
        {
            _title = title;
            _author = author;
            _summary = summary;

        }

        //create method to print out info
        public void PrintBookInfo()
        {
            Console.WriteLine(_title);
            Console.WriteLine(_author);
            Console.WriteLine(_summary);

        }

    }
}
