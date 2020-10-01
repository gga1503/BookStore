<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GracielaBookStore.View.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .content {
            position: relative;
            padding-left: 5%;
            padding-right: 5%;
        }

        .register-hyperlink {
            margin-top: 10%;
        }

        .remember-me-checkbox {
            position: relative;
            margin-top: 1%;
        }

        .error-message {
            position: absolute;
            color: red;
        }
    </style>

    <div class="content">
        <div>
            <h2>Login </h2>
        </div>
        <br />
        <div class="email">
            <asp:Label Text="Username" Width="100px" runat="server"></asp:Label>
            <asp:TextBox ID="UsernameInput" runat="server"></asp:TextBox>
        </div>
        <br />

        <div class="pass">
            <asp:Label Text="Password" Width="100px" runat="server"></asp:Label>
            <asp:TextBox ID="PassInput" runat="server" TextMode="Password"></asp:TextBox>
        </div>

        <div class="remember-me-checkbox">
            <asp:CheckBox ID="RememberMe" Text="Remember me" runat="server" />
        </div>
        <br />

        <asp:Button ID="LoginButton" runat="server" Text="Log In" OnClick="LoginButton_Click" />
        <br />

        <div class="error-message">
            <asp:Label runat="server" ID="errorMessage"></asp:Label>
        </div>

        <div class="register-hyperlink">
            <asp:HyperLink ID="registerHyperlink"
                NavigateUrl="~/View/Guest/Register/Register.aspx"
                Text="Register Account"
                runat="server"></asp:HyperLink>
        </div>
    </div>
</asp:Content>
