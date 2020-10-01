using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GracielaBookStore.View;
using GracielaBookStore;


namespace GracielaBookStore.View.Member.Home
{
    public partial class Home : System.Web.UI.Page
    {
        public string username { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            username = Response.Cookies["UserUsername"].Value.ToString();

            if (Response.Cookies["UserRoleID"].Value != "1")
            {
                ViewGenresButton.Visible = false;
                ViewUsersButton.Visible = false;
                InsertGenreButton.Visible = false;
                InsertBookButton.Visible = false;
            }
            var book = new Book()
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



        protected void InsertBookButton_Click(object sender, EventArgs e)
        {
            AppRouting.InsertBookPage();
        }

        protected void InsertGenreButton_Click(object sender, EventArgs e)
        {
            AppRouting.InsertGenrePage();
        }
    }
}