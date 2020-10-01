using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GracielaBookStore.Factory;
using GracielaBookStore.Repository;
using GracielaBookStore.Models;


namespace GracielaBookStore.View.Administrator.View_Genres
{
    public partial class ViewGenres : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Genre> genre = GenreRepository.GetAllGenres();

            for (int i = 0; i < genre.Count; i++)
            {
                TableRow newRow = new TableRow(); GenreTable.Controls.Add(newRow);
                TableCell numberCell = new TableCell(); numberCell.Controls.Add(new Label() { Text = (i + 1) + "." }); newRow.Cells.Add(numberCell);
                TableCell genreCell = new TableCell(); genreCell.Controls.Add(new Label() { Text = genre[i].GenreName}); newRow.Cells.Add(genreCell);
                TableCell descriptionCell = new TableCell(); descriptionCell.Controls.Add(new Label() { Text = genre[i].Description}); newRow.Cells.Add(descriptionCell);
                TableCell updateButtonCell = new TableCell(); Button updateButton = new Button() { ID = (i + 1) + "_E", Text = "Update", CssClass = "btn btn-warning" };
                updateButton.Click += updateButton_Click; updateButtonCell.Controls.Add(updateButton); newRow.Cells.Add(updateButtonCell);
                TableCell deleteButtonCell = new TableCell(); Button deleteButton = new Button() { ID = (i + 1) + "_D", Text = "Delete", CssClass = "btn btn-danger" };
                deleteButton.Click += deleteButton_Click; deleteButtonCell.Controls.Add(deleteButton); newRow.Cells.Add(deleteButtonCell);
            }

            if (Response.Cookies["UserRoleID"].Value != "1")
            {
                ViewGenresButton.Visible = false;
                ViewBooksButton.Visible = false;
                InsertGenreButton.Visible = false;
                InsertBookButton.Visible = false;
            }
        }
        protected void updateButton_Click(object sender, EventArgs e)
        {
            AppRouting.UpdateGenrePage();
        }
        protected void deleteButton_Click(object sender, EventArgs e)
        {
            AppRouting.ViewGenresPage();
        }
        protected void HomeButton_Click(object sender, EventArgs e)
        {
            AppRouting.HomePage();
        }

        protected void ProfileButton_Click(object sender, EventArgs e)
        {
            AppRouting.ViewProfilePage();
        }

        protected void ViewgenreButton_Click(object sender, EventArgs e)
        {
            AppRouting.ViewGenresPage();
        }


        protected void ViewUsersButton_Click(object sender, EventArgs e)
        {
            AppRouting.ViewUsersPage();
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

        protected void ButtonInsert_Click(object sender, EventArgs e)
        {

            AppRouting.InsertGenrePage();
        }
    }
    }
}