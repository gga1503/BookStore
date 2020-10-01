using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using GracielaBookStore.Factory;
using GracielaBookStore.Repository;
using GracielaBookStore.Models;

namespace GracielaBookStore.View.Administrator.Insert_Genre
{
    public partial class InsertGenre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Response.Cookies["UserRoleID"].Value != "1")
            {
                ViewGenresButton.Visible = false;
                ViewBooksButton.Visible = false;
                InsertGenreButton.Visible = false;
                InsertBookButton.Visible = false;
            }
        }
        protected void HomeButton_Click(object sender, EventArgs e)
        {
            AppRouting.HomePage();
        }

        protected void ProfileButton_Click(object sender, EventArgs e)
        {
            AppRouting.ViewProfilePage();
        }

        protected void ViewBooksButton_Click(object sender, EventArgs e)
        {
            AppRouting.ViewBooksPage();
        }


        protected void ViewUsersButton_Click(object sender, EventArgs e)
        {
            AppRouting.ViewUsersPage();
        }

        protected void ViewGenresButton_Click(object sender, EventArgs e)
        {
            AppRouting.ViewGenresPage();
        }


        protected void InsertBookButton_Click(object sender, EventArgs e)
        {
            AppRouting.InsertBookPage();
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            if (Session["UserUsername"] != null)
            {
                Session.Remove("UserUsername");
                Response.Cookies.Remove("Username");
                Response.Cookies.Remove("UserPass");
                Response.Cookies["UserRoleID"].Value = "3";
            }

            AppRouting.LoginPage();
        }
        protected void InsertButton_Click(object sender, EventArgs e)
        {
            bool submitError = checkInput();

            if (!submitError)
            {
                SendDataToDatabase();
                Response.Redirect("~/View/Administrator/View Genres/ViewGenres.aspx");
            }
        }


        private void SendDataToDatabase()
        {
            var genre = GenreFactory.InsertGenre(
                GenreNameInput.Text,
                DescriptionInput.Text
                );
            GenreRepository.InsertGenre(genre);
        }


        private bool checkInput()
        {
            bool error = false;

            if (GenreNameInput.Text.Length <3)
            {
                error = true;
                errorMessage.Text = "Must be Long than 3 characters";
            }
            else if (DescriptionInput.Text.Length < 10)
            {
                error = true;
                errorMessage.Text = "Must be Long than 10 characters";
            }
            
            return error;
        }
    }
}