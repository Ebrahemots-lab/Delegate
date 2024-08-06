using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class BookFunctions
    {

        public static string GetISBN(Book b) 
        {
            return b.ISBN;
        }
        public static string GetTitle(Book b) 
        {
            return b.Title;
        }

        public static string GetAuthors(Book b) 
        {
            return b.GetAuthors();
        }

        public static string GetPrice(Book b) 
        {
            return $"{b.Price}";
        }
    }
}
