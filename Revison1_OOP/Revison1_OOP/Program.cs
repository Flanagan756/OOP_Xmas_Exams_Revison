using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revison1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create and fill objects
            Book B1 = new Book("Slaughter House 5", "Kurt Vonegan", new DateTime(1972,04,23), 546, Genre.Literature);
            Book B2 = new Book("Scott Pilgrim VS the World", "Byran O'Realy", new DateTime(2012, 12, 02), 341, Genre.Literature);
            Book B3 = new Book("1982", "George Orwell", new DateTime(1972, 04, 23), 546, Genre.Literature);
            Book B4a = new Book("The Stranger", "Albert Camus", new DateTime(1942, 10, 12), 865, Genre.Literature);
            Book B4b = new Book("The Rebel", "Albert Camus", new DateTime(1949, 12, 02), 4445, Genre.Literature);
            Book B5 = new Book("The Hobbit", "JRR Tolkien", new DateTime(1922, 06, 19), 1202, Genre.Literature);

            //Use the other half empty constructors
            Book B6 = new Book();
            Book B7 = new Book("Getting through it", "Harry Flanagan");

            //Create a Reading List from the Book object
            List<Book> ReadingList = new List<Book>();

            //Add all of the B's into the list
            ReadingList.Add(B1);
            ReadingList.Add(B2);
            ReadingList.Add(B3);
            ReadingList.Add(B4a);
            ReadingList.Add(B4b);
            ReadingList.Add(B5);
            ReadingList.Add(B6);
            ReadingList.Add(B7);

            //Diplay using method
            Display(ReadingList);

            Console.WriteLine("\nSorting the reading list by Author, then Book Title\n");
            ReadingList.Sort(); /*Calls from the compare method within the Book class*/

            Display(ReadingList);

            Console.WriteLine("\nCalculating the age...\n");

            DisplayWithAge(ReadingList);


        }
        //Methods

            //Used to display all of the items within the list given
        private static void Display(List<Book> playlist)/*list is passed through*/
        {
            Console.WriteLine("{0,-30}{1,-30}{2,-10}{3,-15}{4,-10}", "Author", "Title", "Pages", "Genre", "Publication Date"); /*Title*/

            foreach (Book item in playlist) /*For each Book(Object varible) item(Name it whatever) in playlist(Name it what you want as long as it matches with above)*/
            {
                Console.WriteLine($"{item.Author,-30}{item.Title,-30}{item.Pages,-10}{item.Genre,-15}{item.Published.ToShortDateString()}");
            }

        }
        private static void DisplayWithAge(List<Book> playlist)
        {
            Console.WriteLine("{0,-30}{1,-30}{2,-10}{3,-15}{4,-17}{5,-5}", "Artist", "Song", "Duration", "Genre", "Publication Date", "Age");

            foreach (Book item in playlist)
            {
                Console.WriteLine($"{item.Author,-30}{item.Title,-30}{item.Pages,-10}{item.Genre,-15}{item.Published.ToShortDateString(),-17}{item.Age,-5}");
            }

        }

    }
}
