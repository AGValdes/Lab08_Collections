using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Phils_Lending_Library.Classes
{
    public class Library<Book> : IEnumerable
    {
        Book[] library = new Book[5];
        int count;
        /// <summary>
        /// The below method adds a book to our library
        /// </summary>
        /// <param name="book">book to be added to the list</param>
        public void Add(Book book)
        {
            //if the count is equal to the array's length, we know we've reached the end of 
            //the array and need to make it larger, so we double it and set the next index to the book.
            if (count == library.Length)
            {
                Array.Resize(ref library, library.Length * 2);
            }
            library[count++] = book;
            
        }

        public void Remove(Book book)
        {

        }

        public int Count()
        {
            return count;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return library[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}