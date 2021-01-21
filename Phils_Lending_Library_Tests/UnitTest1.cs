using System;
using Xunit;
using Phils_Lending_Library;
using Phils_Lending_Library.Classes;

namespace Phils_Lending_Library_Tests
{
    public class Phils_Lending_Library_Tests
    {
        [Fact]
        public void Add_Book_To_Library_That_Exists()
        {
            Library<Book> Library = new Library<Book>();
            Book bookThatExists = new Book("The Lord of the Rings: Trilogy", "J.R.R.", "Tolkien", 1007, Genre.Fantasy);
            Library.Add(bookThatExists);
            int expected = 1;
            Assert.Equal(expected, Library.Count());
        }

        [Fact]
        public void Remove_Book_From_Library()
        {
            Library<Book> Library = new Library<Book>();
            Book book1 = new Book("The Lord of the Rings: Trilogy", "J.R.R.", "Tolkien", 1007, Genre.Fantasy);
            Book book2 = new Book("The Lord of the Rings: Trilogy", "J.R.R.", "Tolkien", 1007, Genre.Fantasy);
            Library.Add(book1);
            Library.Add(book2);
            Book removed = Library.Remove(book2);

            Assert.Equal(book2, removed);
        }

        [Fact]
        public void Cant_Remove_Book_From_Library_That_Doesnt_Exist()
        {
            Library<Book> Library = new Library<Book>();
            Book book1 = new Book("The Lord of the Rings: Trilogy", "J.R.R.", "Tolkien", 1007, Genre.Fantasy);
            Book book2 = new Book("The Lord of the Rings: Trilogy", "J.R.R.", "Tolkien", 1007, Genre.Fantasy);
            Library.Add(book1);
            Library.Add(book1);
            Library.Add(book1);
            Book removed = Library.Remove(book2);

            Assert.Equal(default(Book), removed);
        }
    }
}
