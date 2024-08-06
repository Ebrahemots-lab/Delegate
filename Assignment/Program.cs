namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            // Book b1 = new Book("11x1" , "Beautiful and Beast", new string[] { "Ebrahem" , "Ashraf"},new DateTime (2022,10,11),500);
            // Book b2 = new Book("11x2" , "Game Of Thrones", new string[] { "Ahmed" , "Alebashy"},new DateTime (2023,7,12),800);
            // Book b3 = new Book("11x3" , "Sniper", new string[] { "Ots" , "Hema"},new DateTime (2021,8,13),100);


            // List<Book> books = new List<Book>() { b1 , b2 , b3 };



            //LibraryEngine.ProcessBooks(books,BookFunctions.GetPrice);

            // Func<Book, string> getIsbn = delegate (Book b) { return b.ISBN; };

            // foreach(Book b in books) 
            // {
            //     Console.WriteLine(getIsbn.Invoke(b));
            // }


            // Func<Book, DateTime> getDate = (book) => book.PublicationDate;
            // Console.WriteLine(getDate.Invoke(b1)); 
            #endregion

            #region Part2

            List<string> names = new List<string> {"Ahmed","Ashraf" , "ots", "a"};
            List<int> numbers = new List<int> {23, 4, 4, 5,3}; // 6 - 1 

            //bool isValid =  ListMethods<string>.Exist(names,(name) => name == "ots");
            //Console.WriteLine(isValid);


            // string element = ListMethods<string>.Find(names, (name) => name == "Ebrahem");
            // Console.WriteLine(element);


            //List<string> elements = ListMethods<string>.FindAll(names, (name) => name == "Ebrahem");
            //foreach(string element in elements) 
            //{
            //    Console.WriteLine(element);
            //}

            //int indexs = numbers.FindIndex(0,(x) => x == 1);
            //int index = ListMethods<int>.FindIndex(numbers, (number) => number == 1);
            //Console.WriteLine(index);



            //string result = ListMethods<string>.FindLast(names, (name) => name == "ots");
            //Console.WriteLine(result);


            //int x = ListMethods<int>.FindLastIndex(numbers, (number) => number == 4);
            //Console.WriteLine(x);

            //numbers.ForEach((number) => { Console.WriteLine(number); });
            //ListMethods<string>.Foreach(names, (name) => Console.WriteLine(name));


            bool isValid = ListMethods<int>.TrueForAll(numbers,(number) => number > 100);
            Console.WriteLine(isValid);

            #endregion

        }

        static bool isFound(string name) 
        {
            return name == "Ots";
        }
    }
}
