using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GracielaBookStore.Models;

namespace GracielaBookStore.Factory
{
    public class GenreFactory
    {
        public static Genre InsertGenre(string genreName, string description)
        {
            var genreData = new Genre()
            {
                GenreName = genreName,
                Description = description
            };

            return genreData;
        }

        public static Genre UpdateGenre(int genreID, string genreName, string description)
        {
            var genreData = new Genre()
            {
                GenreID = genreID,
                GenreName = genreName,
                Description = description
            };

            return genreData;
        }
    }
}