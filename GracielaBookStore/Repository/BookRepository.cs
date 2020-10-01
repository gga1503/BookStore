using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Data.Entity.Core.Objects;
using GracielaBookStore.Models;

namespace GracielaBookStore.Repository
{
    public class BookRepository
    {
        private static DataTable dt = new DataTable();

        public static List<Book> FiveRandomBook()
        {
            var query = "SELECT [Name] FROM [Book] ORDER BY RAND() LIMIT 5";
            dt = DbManager.Get(query);

            var books = new List<Book>();

            if (dt.Rows.Count > 0)
                for (var i = 0; i < 5; i++)
                {
                    var book = new Book();
                    book.Name = dt.Rows[i]["Name"].ToString();
                    books.Add(book);
                }

            return books;
        }

        public static List<Book> GetAllBookAndGenreInfo()
        {
            var dtGenre = new DataTable();

            var query = "SELECT * FROM [Book]";
            dt = DbManager.Get(query);

            var genres = GenreRepository.GetAllGenres();

            if (dt.Rows.Count > 0 && genres.Count > 0)
            {
                var books = new List<Book>();

                for (var i = 0; i < 5; i++)
                {
                    var bookGenreID = Convert.ToInt32(dt.Rows[i]["GenreID"]);

                    var book = new Book()
                    {
                        BookID = Convert.ToInt32(dt.Rows[i]["BookID"].ToString()),
                        Name = dt.Rows[i]["Name"].ToString(),
                        GenreID = bookGenreID,
                        Description = dt.Rows[i]["Description"].ToString(),
                        Stock = Convert.ToInt32(dt.Rows[i]["Stock"]),
                        Price = Convert.ToInt32(dt.Rows[i]["Price"]),
                    };

                    // Masukkin data Genre yang sesuai dengan Genre ID di Bukunya.
                    var j = 0;
                    while (true)
                    {
                        if (genres[j].GenreID == bookGenreID)
                        {
                            book.Genre = genres[j];
                            break;
                        }

                        j++;
                    }

                    books.Add(book);
                }

                return books;
            }

            return null;
        }

        public static void InsertBook(Book bookData)
        {
            var query = "INSERT INTO[Book]([Name], [GenreID], [Description], [Stock], [Price]) VALUES " +
                        $"('{bookData.Name}', {bookData.GenreID}, '{bookData.Description}', {bookData.Stock}, {bookData.Price})";

            DbManager.Execute(query);
        }

        public static void UpdateBook(Book bookData)
        {
            var query = $"UPDATE [Book] SET [GenreID] = {bookData.GenreID}, [Name] = '{bookData.Name}', [Description] = '{bookData.Description}', [Stock] = {bookData.Stock}, [Price] = {bookData.Price} WHERE[BookID] = {bookData.BookID}";

            DbManager.Execute(query);
        }
    }
}