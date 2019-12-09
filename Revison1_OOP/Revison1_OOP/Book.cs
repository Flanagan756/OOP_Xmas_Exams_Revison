using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revison1_OOP
{
    //enum
    public enum Genre
    {
        //What genres can be selcted within the Genre enum
        Fiction,
        Biography,
        Computing,
        Literature,
        Unkown
    }
    public class Book: IComparable<Book>
    {
        //Proterties
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
        public int Pages { get; set; }
        public Genre Genre { get; set; } /*Use the enumber object*/

        private int age;

        public int Age
        {
            get
            {
                age = DateTime.Now.Year - Published.Year;
                return age;
            }

        }

        //Constructor
        public Book(string title, string author, DateTime published, int pages, Genre genre)
        {
            Title = title;
            Author = author;
            Published = published;
            Pages = pages;
            Genre = genre;

        }
        /*Use two other constrors and link them using this.*/

        //Only have name and author
        public Book(string title, string author) : this(title, author, DateTime.Now,000, Genre.Unkown)
        { 

        }

        //No infomation passed through
        public Book() : this("Unknown","Unknown", DateTime.Now,000,Genre.Unkown)
        {

        }

        //Override to string
        public override string ToString()
        {
            /*Use .ToShortDateString() to ensure that the date is shown without time*/                                          
            return $"{Author} {Title} {Pages} {Genre} {Published.ToShortDateString()}";
        }

        public int CompareTo(Book other)
        {
            int returnValue = this.Author.CompareTo(other.Author); //Compare authors

            if (returnValue == 0)
            {
                returnValue = this.Title.CompareTo(other.Title); //Compare title after the author
            }

            return returnValue; //Return the calue
        }
    }




}



