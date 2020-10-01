using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GracielaBookStore.Factory;
using GracielaBookStore.Repository;
using GracielaBookStore.Models;


namespace GracielaBookStore.View.Member.View_Profile
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<User> users = UserRepository.GetAllUsers();

            for (int i = 0; i < users.Count; i++)
            {
                TableRow newRow = new TableRow();
                ProfileTable.Controls.Add(newRow);

                TableCell numberCell = new TableCell();
                numberCell.Controls.Add(new Label() { Text = (i + 1) + "." });
                newRow.Cells.Add(numberCell);

                TableCell usernameCell = new TableCell();
                usernameCell.Controls.Add(new Label()
                {
                    Text = users[i].Username
                });
                newRow.Cells.Add(usernameCell);

                TableCell nameCell = new TableCell();
                nameCell.Controls.Add(new Label()
                {
                    Text = users[i].Name
                });
                newRow.Cells.Add(nameCell);

                TableCell roleCell = new TableCell();
                roleCell.Controls.Add(new Label()
                {
                    Text = users[i].Role.RoleName
                });
                newRow.Cells.Add(roleCell);

                TableCell genderCell = new TableCell();
                genderCell.Controls.Add(new Label()
                {
                    Text = users[i].Gender.ToString()
                });
                newRow.Cells.Add(genderCell);

                TableCell phoneCell = new TableCell();
                phoneCell.Controls.Add(new Label()
                {
                    Text = users[i].PhoneNumber.ToString()
                });
                newRow.Cells.Add(phoneCell);

                TableCell addressCell = new TableCell();
                addressCell.Controls.Add(new Label()
                {
                    Text = users[i].Address
                });
                newRow.Cells.Add(addressCell);

            }
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

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            AppRouting.UpdateProfilePage();
        }

        protected void ChangePassword_Click(object sender, EventArgs e)
        {
            AppRouting.ChangePasswordPage();
        }
    }
}