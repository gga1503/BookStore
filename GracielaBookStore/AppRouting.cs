using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GracielaBookStore
{
    public class AppRouting
    {
        public static void LoginPage()
        {
            HttpContext.Current.Response.Redirect("~/View/Guest/Login/Login.aspx");
        }

        public static void HomePage()
        {
            HttpContext.Current.Response.Redirect("~/View/Home/Home.aspx");
        }

        public static void ViewProfilePage()
        {
            HttpContext.Current.Response.Redirect("~/View/Member/View Profile/ViewProfile.aspx");
        }

        public static void UpdateProfilePage()
        {
            HttpContext.Current.Response.Redirect("~/View/Member/Update Profile/UpdateProfile.aspx");
        }

        public static void ChangePasswordPage()
        {
            HttpContext.Current.Response.Redirect("~/View/Administrator/Change Password/ChangePassword.aspx");
        }

        public static void UpdateGenrePage()
        {
            HttpContext.Current.Response.Redirect("~/View/Administrator/Update Genre/UpdateGenre.aspx");
        }

        public static void ViewBooksPage()
        {
            HttpContext.Current.Response.Redirect("~/View/Member/View Books/ViewBooks.aspx");
        }

        public static void ViewUsersPage()
        {
            HttpContext.Current.Response.Redirect("~/View/Administrator/View Users/ViewUsers.aspx");
        }

        public static void ViewGenresPage()
        {
            HttpContext.Current.Response.Redirect("~/View/Administrator/View Genres/ViewGenres.aspx");
        }

        public static void InsertBookPage()
        {
            HttpContext.Current.Response.Redirect("~/View/Administrator/Insert Book/InsertBook.aspx");
        }

        public static void InsertGenrePage()
        {
            HttpContext.Current.Response.Redirect("~/View/Administrator/Insert Genre/InsertGenre.aspx");
        }
    }
}