using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    //public delegate string ProcessBooks(Book b);
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books , Func<Book,string> fPtr) 
        {
            foreach(Book b in books) 
            {
                Console.WriteLine(fPtr(b));
            }
        }

        //public static void PrintBookPrice(List<Book> books)
        //{
        //    foreach (Book b in books)
        //    {
        //        Console.WriteLine(b.Price);
        //    }
        //}

        //public static void PrintBookAuthors(List<Book> books)
        //{
        //    foreach (Book b in books)
        //    {
        //        Console.WriteLine(b.GetAuthors());
        //    }
        //}
    }
}
