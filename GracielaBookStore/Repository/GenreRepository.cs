using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using GracielaBookStore.Models;

namespace GracielaBookStore.Repository
{
    public class GenreRepository
    {
        static DataTable dt = new DataTable();

        public static List<Genre> GetAllGenres()
        {
            string query = "SELECT * FROM [Genre]";
            dt = DbManager.Get(query);

            if (dt.Rows.Count > 0)
            {
                List<Genre> genres = new List<Genre>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Genre genre = new Genre()
                    {
                        GenreID = Convert.ToInt32(dt.Rows[i]["GenreID"]),
                        GenreName = dt.Rows[i]["Name"].ToString()
                    };

                    genres.Add(genre);
                }
                return genres;
            }
            return null;
        }

        public static void InsertGenre(Genre genreData)
        {
            var query = $"INSERT INTO[Genre]([GenreName], [Description]) VALUES ('{genreData.GenreName}', {genreData.Description})";
            DbManager.Execute(query);
        }

        public static void UpdateGenre(Genre genreData)
        {
            var query = $"UPDATE [Genre] SET [GenreName] = '{genreData.GenreName}', [Description] = '{genreData.Description}' WHERE[GenreID] = {genreData.GenreID}";

            DbManager.Execute(query);
        }
    }
}
