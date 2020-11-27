using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();
            Book book6 = new Book();

            book1.SetBook("Джон Р.Р. Толкин", "Властелин Колец", 544, 1978);
            book2.SetBook("Джейн Остин", "Гордость и предубеждение", 315, 2016);
            book3.SetBook("Дуглас Адамс", "Автостопом по галлактике", 432, 2010);
            book4.SetBook("Харпер Ли", "Убить пересмешника", 340, 1999);
            book5.SetBook("Эмили Бронте", "Грозовой перевал", 259, 2002);
            book6.SetBook("Льюис Кэрролл", "Алиса в стране чудес", 560, 2007);

            Book[] List = { book1, book2, book3, book4, book5, book6 };
            
            Array.Sort<Book>(List);
            ShowArr("Отсортированные по году издания книги:", List);
        }
        public static void ShowArr(string A, Book[] a)
        {
            Console.WriteLine(A);
            for (int n = 0; n < a.Length; n++)
            {
                a[n].Show();
            }

        }
    }
}
