using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Book
    {
        public string ISBN { get; set; }

        public string Title { get; set; }

        public string[] Authors { get; set; }

        public DateTime PublicationDate { get; set; }
        public Decimal Price { get; set; }
        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }


        
        public string GetAuthors() 
        {
            string authorsName = string.Empty;

            for(int i = 0; i < Authors.Length; i++) 
            {
                authorsName += $"{Authors[i]},";
            }

            return authorsName;
        }
        public override string ToString()
        {
            return $"ISBN: {ISBN} :: Title: {Title} :: Authors:{GetAuthors()} :: PublicationDate: {PublicationDate} :: Price: {Price}";
        }







    }
}
