using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using GracielaBookStore.Factory;
using GracielaBookStore.Models;
using GracielaBookStore.Repository;

namespace GracielaBookStore.View.Guest.Register
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            bool submitError = CheckInput();

            if (!submitError)
            {
                SendDataToDatabase();
                Response.Redirect("~/View/Guest/Login/Login.aspx");
            }
        }

        private bool CheckInput()
        {
            bool error = false;


            if (UsernameInput.Text.Length < 3)
            {
                error = true;
                errorMessage.Text = "Username length is less than 3 characters!";
            }
            else if (!EmailInput.Text.Contains('@'))
            {
                error = true;
                errorMessage.Text = "Email must contains \"@\"!";
            }
            else if (PasswordInput.Text.Length < 8)
            {
                error = true;
                errorMessage.Text = "Username length is less than 8 characters!";
            }
            else if (PasswordInput.Text != PasswordConfirmInput.Text)
            {
                error = true;
                errorMessage.Text = "Password confirmation is not matched!";
            }
            else if (NameInput.Text == "")
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

        private void SendDataToDatabase()
        {
            User userData = UserFactory.InsertUser(
                UsernameInput.Text.ToLower(),
                EmailInput.Text.ToLower(),
                PasswordInput.Text,
                NameInput.Text,
                Convert.ToInt16(GenderInput.Text),
                Convert.ToInt32(PhoneNumberInput.Text),
                AddressInput.Text);

            UserRepository.InsertUser(userData);
        }
    }
}