using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using GracielaBookStore.Factory;
using GracielaBookStore.Repository;

namespace GracielaBookStore.View.Administrator.Update_Book
{
    public partial class Update : System.Web.UI.Page
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

        protected void InsertGenreButton_Click(object sender, EventArgs e)
        {
            AppRouting.InsertGenrePage();
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

        private void SendDataToDatabase()
        {
            var book = BookFactory.UpdateBook(
               Convert.ToInt32(UpdateBook.Text),
               BookNameInput.Text,
               Convert.ToInt32(BookGenre.Text),
               DescriptionInput.Text,
               Convert.ToInt32(BookStock.Text),
               Convert.ToInt32(BookPrice.Text));

            BookRepository.UpdateBook(book);
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            bool submitError = checkInput();

            if (!submitError)
            {
                SendDataToDatabase();
                Response.Redirect("~/View/Member/View Books/ViewBooks.aspx");
            }
        }

        private bool checkInput()
        {
            bool error = false;

            if (BookNameInput.Text == "")
            {
                error = true;
                errorMessage.Text = "Name is empty!";
            }
            else if (DescriptionInput.Text.Length < 10)
            {
                error = true;
                errorMessage.Text = "Must be Long than 10 characters";
            }
            else if (!Regex.IsMatch(BookStock.Text, @"^\d+$"))
            {
                error = true;
                errorMessage.Text = "Phone number must be numeric and more than 0!";
            }
            else if (!Regex.IsMatch(BookPrice.Text, @"^\d+$"))
            {
                error = true;
                errorMessage.Text = "Must be numeric and more than 0!";
            }

            return error;
        }
    }
}