using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GracielaBookStore.Factory;
using GracielaBookStore.Models;
using GracielaBookStore.Repository;
using GracielaBookStore;

namespace GracielaBookStore.View
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack && Request.Cookies["UserUsername"] != null)
            {
                UsernameInput.Text = Request.Cookies["UserUsername"].Value.ToString();
                PassInput.Text = Request.Cookies["UserPass"].Value.ToString();
            }
            else if (IsPostBack)
            {
                // Set Role = Member ketika pertama kali load page.
                Response.Cookies["UserRoleID"].Value = "3";
            }

            // Jika Role bukan Member, maka hide hyperlink
            if(Response.Cookies["UserRoleID"].Value == "3")
            {
                registerHyperlink.Visible = true;
            }
            else
            {
                registerHyperlink.Visible = true;
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string Username = UsernameInput.Text.ToLower();
            string password = PassInput.Text;

            User userLoginData = UserFactory.UserLogin(Username, password);
            User loginResponse = UserRepository.UserLogin(userLoginData);

            // Kalau response dari database = null.
            if (loginResponse == null)
            {
                errorMessage.Text = "Incorrect Username or password!";
            }
            else
            {
                // Kalau akun dibanned.
                if (loginResponse.Banned == true)
                {
                    errorMessage.Text = "Your account is Banned!";
                }
                // Kalau login sukses.
                else
                {
                    Session.Timeout = 60;
                    Session["UserUsername"] = Username;

                    if (RememberMe.Checked)
                    {
                        Response.Cookies["UserUsername"].Value = Username;
                        Response.Cookies["UserPass"].Value = password;
                        Response.Cookies["UserRoleID"].Value = $"{loginResponse.RoleID}";
                    }

                    AppRouting.HomePage();
                }
            }
        }
    }
}