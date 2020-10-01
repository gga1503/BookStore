using GracielaBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GracielaBookStore.Repository;

namespace GracielaBookStore.View.Member.View_Books
{
    public partial class ViewBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            List<Book> books = BookRepository.GetAllBookAndGenreInfo();

            for (int i = 0; i < books.Count; i++)
            {
                TableRow newRow = new TableRow(); BookTable.Controls.Add(newRow);
                TableCell numberCell = new TableCell(); numberCell.Controls.Add(new Label() { Text = (i + 1) + "." }); newRow.Cells.Add(numberCell);
                TableCell nameCell = new TableCell(); nameCell.Controls.Add(new Label() { Text = books[i].Name }); newRow.Cells.Add(nameCell);
                TableCell genreCell = new TableCell(); genreCell.Controls.Add(new Label() { Text = books[i].Genre.GenreName }); newRow.Cells.Add(genreCell);
                TableCell descriptionCell = new TableCell(); descriptionCell.Controls.Add(new Label() { Text = books[i].Description }); newRow.Cells.Add(descriptionCell);
                TableCell stockCell = new TableCell(); stockCell.Controls.Add(new Label() { Text = books[i].stockCell.ToString() }); newRow.Cells.Add(stockCell);
                TableCell priceCell = new TableCell(); priceCell.Controls.Add(new Label() { Text = books[i].Price.ToString() }); newRow.Cells.Add(priceCell);

                if (Response.Cookies["UserRoleID"].Value != "1")
                {
                    Actiontable.Visible = false;
                    ButtonInsert.Visible = false;
                    TableCell updateButtonCell = new TableCell(); updateButtonCell.Visible = false; Button updateButton = new Button() { ID = (i + 1) + "_E", Text = "Update", CssClass = "btn btn-warning" };
                    updateButton.Click += updateButton_Click; updateButtonCell.Controls.Add(updateButton); newRow.Cells.Add(updateButtonCell);
                    TableCell deleteButtonCell = new TableCell(); deleteButtonCell.Visible = false; Button deleteButton = new Button() { ID = (i + 1) + "_D", Text = "Delete", CssClass = "btn btn-danger" };
                    deleteButton.Click += deleteButton_Click; deleteButtonCell.Controls.Add(deleteButton); newRow.Cells.Add(deleteButtonCell);
                }
            }
            if (Response.Cookies["UserRoleID"].Value != "1")
            {
                ViewGenresButton.Visible = false;
                ViewUsersButton.Visible = false;
                InsertGenreButton.Visible = false;
                InsertBookButton.Visible = false;
            }
        }
           

        protected void updateButton_Click(object sender, EventArgs e)
        {

        }
        protected void deleteButton_Click(object sender, EventArgs e)
        {

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

        protected void ButtonInsert_Click(object sender, EventArgs e)
        {
            AppRouting.InsertBookPage();
        }
    }
}