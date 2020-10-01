<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="GracielaBookStore.View.Administrator.Change_Password.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        h5 {
            font-size: 20pt;
            margin-top: 10px;
        }
    </style>

    <div class="nav">
        <asp:Button class="nav-button" ID="HomeButton" runat="server" Text="Home" OnClick="HomeButton_Click" />
        <asp:Button class="nav-button" ID="ProfileButton" runat="server" Text="View Profile" OnClick="ProfileButton_Click" />
        <asp:Button class="nav-button" ID="ViewBooksButton" runat="server" Text="View Books" OnClick="ViewBooksButton_Click" />
        <asp:Button class="nav-button" ID="ViewUsersButton" runat="server" Text="View Users" OnClick="ViewUsersButton_Click" />
        <asp:Button class="nav-button" ID="ViewGenresButton" runat="server" Text="View Genres" OnClick="ViewGenresButton_Click" />
        <asp:Button class="nav-button" ID="InsertBookButton" runat="server" Text="Insert Book" />
        <asp:Button class="nav-button" ID="InsertGenreButton" runat="server" Text="Insert Genre" OnClick="InsertGenreButton_Click" />
        <asp:Button class="nav-button" Style="float: right;" ID="LogoutButton" runat="server" Text="Logout" OnClick="LogoutButton_Click" />
    </div>

    <div class="content">
        <asp:Label ID="OldPasswordLabel" Width="160px" runat="server" Text="Old Password"></asp:Label>
        <asp:TextBox ID="OldPasswordInput" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="PasswordNote" runat="server" ForeColor="#ff6600" Text=" *Password not match"></asp:Label>
        <br />

        <asp:Label ID="NewPasswordLabel" Width="160px" runat="server" Text="New Password"></asp:Label>
        <asp:TextBox ID="NewPasswordConfirmInput" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="NewPasswordNote" runat="server" ForeColor="#ff6600" Text=" *Must be longer than 5 characters"></asp:Label>
        <br />

        <asp:Label ID="ConfirmPasswordLabel" Width="160px" runat="server" Text="Confirm Password"></asp:Label>
        <asp:TextBox ID="PasswordConfirmInput" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="ConfirmPasswordNote" runat="server" ForeColor="#ff6600" Text=" *Must be the same as the inputted password"></asp:Label>
        <br />

        <asp:Label runat="server" ID="errorMessage" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="UpdateButton_Click" />
    </div>
</asp:Content>
