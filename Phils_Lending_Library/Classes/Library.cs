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
        /// <summary>
        /// The below method removes a book from the library, and returns the removed book
        /// </summary>
        /// <param name="book">book to be removed</param>
        public Book Remove(Book book)
        {
            int temporaryCounter = 0;
            //Here we are going to make a temporary book array in order to be able to index it
            Book[] temp;
            //learned that we cant set removed variable without a default
            Book removed = default(Book);
            //if the count has not reached and is not near the end of the array "library", since we've doubled it
            //we set temp equal to an array with a length that is one less, respresenting the removed book.
            if(count < library.Length / 2)
            {
                temp = new Book[count - 1];
            }
            else
            {
                temp = new Book[library.Length];
            }
            for (int i = 0; i < count; i++)
            {
                //this if checks if the book is in the library
                if (library[i] != null)
                {
                    //if the element of library at i equals the input book, set removed equal to it for return.
                    if(library[i].Equals(book))
                    {
                        removed = library[i];
                    }
                    else
                    {
                        temp[temporaryCounter] = library[i];
                        temporaryCounter++;
                    }
                }
                //set the library equal to our new temp array with the removed book
            library = temp;
                //decriment the counter to represent one less book
            count--;
            }
            return removed;
        }
        /// <summary>
        /// The below method returns the current count of books in the library.
        /// </summary>
        /// <returns>an integer that represents how many books there are in the library</returns>
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