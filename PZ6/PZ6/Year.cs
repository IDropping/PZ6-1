using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ6
{

    internal class Year
    {
        private int _year;
        private int _pages;
        private book _bookName;


        public int god
        {
            get => _year;
        }
        public int pages
        {
            get => _pages;
        }
        private book BookName
        {
            get => _bookName;
        }
        public string Book
        {
            get { return BookName != null ? BookName.Name : "Нет имени"; }
        }
        public Year(int god, int pages,book book)
        {
            _year = god;
            _pages = pages;
            _bookName = book;
        }
    }
}
