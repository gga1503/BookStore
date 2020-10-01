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


namespace GracielaBookStore.View.Member.Update_Profile
{
    public partial class UpdateProfile : System.Web.UI.Page
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
            User userData = UserFactory.UpdateProfile(
                NameInput.Text,
                Convert.ToInt16(GenderInput.Text),
                Convert.ToInt32(PhoneNumberInput.Text),
                AddressInput.Text);

            UserRepository.UpdateProfile(userData);
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


           if (NameInput.Text == "")
            {
                error = true;
                errorMessage.Text = "Name is empty!";
            }
            else if (!Regex.IsMatch(PhoneNumberInput.Text, @"^\d+$"))
            {
                error = true;
                errorMessage.Text = "Phone number must be numeric!";
            }
            else if (!AddressInput.Text.Contains("Street"))
            {
                error = true;
                errorMessage.Text = "Address must contain \"Street\"!";
            }

            return error;
        }
    }
}