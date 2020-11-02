using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book : IComparable
    {
        private string author;
        private string title;
        private int pages;
        private int year;

        public void SetBook(string author, string title, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            this.year = year;
        }

        public void Show()
        {
            Console.WriteLine("\nКнига: \nАвтор: {0} \nНазвание: {1} \nГод издания: {2} \n{3} стр. \n", author, title, year, pages);
        }

        int IComparable.CompareTo(object obj)
        {
            Book it = (Book)obj;
            if (this.year == it.year)
                return 0;
            else if (this.year > it.year)
                return 1;
            else return -1;
        }

    }

}
