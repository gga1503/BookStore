using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GracielaBookStore.Models;

namespace GracielaBookStore.Factory
{
    public class BookFactory
    {
        public static Book InsertBook(string name, int genreID, string description, int stock, int price)
        {
            var bookData = new Book()
            {
                Name = name,
                GenreID = genreID,
                Description = description,
                Stock = stock,
                Price = price
            };

            return bookData;
        }

        public static Book UpdateBook(int bookID, string name, int genreID, string description, int stock, int price)
        {
            var bookData = new Book()
            {
                BookID = bookID,
                Name = name,
                GenreID = genreID,
                Description = description,
                Stock = stock,
                Price = price
            };

            return bookData;
        }

    }
}