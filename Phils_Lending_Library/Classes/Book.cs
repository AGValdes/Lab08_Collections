using ClassesPhils_Lending_Library.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Phils_Lending_Library.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }

        public int NumberOfPages { get; set; }

        public Genre Genre { get; set; }

  /// <summary>
  /// The below is a constructor functon to make new Book instances.
  /// </summary>
  /// <param name="title"></param>
  /// <param name="firstName"></param>
  /// <param name="lastName"></param>
  /// <param name="numberOfPages"></param>
  /// <param name="genre"></param>
        public Book(string title, string firstName, string lastName, int numberOfPages, Genre genre)
        {
            {
                Title = title;
                Author = new Author()
                {
                    FirstName = firstName,
                    LastName = lastName
                };
                NumberOfPages = numberOfPages;
                Genre = genre;
            }
        }

    }
    public enum Genre
    {
        SciFi,
        Mystery,
        Fantasy,
        Romance,
        NonFiction
    }
}
