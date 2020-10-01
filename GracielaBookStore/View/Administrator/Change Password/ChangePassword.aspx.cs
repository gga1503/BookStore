using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using GracielaBookStore.Factory;
using GracielaBookStore.Repository;

namespace GracielaBookStore.View.Administrator.Change_Password
{
    public partial class ChangePassword : System.Web.UI.Page
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
            var profileData = UserFactory.ChangePassword(
                Response.Cookies["UserUsername"]?.Value.ToString(),
                PasswordConfirmInput.Text);
                
            UserRepository.ChangePassword(profileData);
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            var submitError = checkInput();

            if (submitError) return;
            SendDataToDatabase();
            Response.Redirect("~/View/Member/View Books/ViewBooks.aspx");
        }

        private bool checkInput()
        {
            var error = false;

            var oldPassword = Response.Cookies["UserPassword"]?.Value.ToString();

            if (oldPassword != OldPasswordInput.Text)
            {
                errorMessage.Text = "Old Password doesn't Match!";
                error = true;
            } else if (NewPasswordConfirmInput.Text != PasswordConfirmInput.Text)
            {
                errorMessage.Text = "New Password doesn't Match!";
                error = true;
            }

            return error;
        }
    }
    
}