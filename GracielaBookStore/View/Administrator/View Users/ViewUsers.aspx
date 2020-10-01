<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewUsers.aspx.cs" Inherits="GracielaBookStore.View.Administrator.View_Users.ViewUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .content {
            margin-top: 10px;
        }

        h1 {
            font-size: 20pt;
            margin-top: 10px;
        }
    </style>
    
    <div class="nav">
        <asp:Button class="nav-button" ID="HomeButton" runat="server" Text="Home" OnClick="HomeButton_Click" />
        <asp:Button class="nav-button" ID="ProfileButton" runat="server" Text="View Profile" OnClick="ProfileButton_Click" />
        <asp:Button class="nav-button" ID="ViewBooksButton" runat="server" Text="View Books" OnClick="ViewBooksButton_Click" />
        <asp:Button class="nav-button" ID="ViewUsersButton" runat="server" Text="View Users" />
        <asp:Button class="nav-button" ID="ViewGenresButton" runat="server" Text="View Genres" OnClick="ViewGenresButton_Click" />
        <asp:Button class="nav-button" ID="InsertBookButton" runat="server" Text="Insert Book" OnClick="InsertBookButton_Click" />
        <asp:Button class="nav-button" ID="InsertGenreButton" runat="server" Text="Insert Genre" OnClick="InsertGenreButton_Click" />
        <asp:Button class="nav-button" Style="float: right;" ID="LogoutButton" runat="server" Text="Logout" OnClick="LogoutButton_Click" />
    </div>

    <div class="content">
        <h1>View Users</h1>
        <br />
        <div id="UsersDataTable" class="w-100" runat="server">
            <div class="col-md-12">
                <div class="container">
                    <asp:Table ID="UserTable" class="table table-bordered text-center" runat="server" Width="1000px">
                        <asp:TableHeaderRow>
                            <asp:TableHeaderCell>No.</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Username</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Role</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Gender</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Phone Number</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Address</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Banned Status</asp:TableHeaderCell>
                            <asp:TableHeaderCell ColumnSpan="2"> Action </asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                    </asp:Table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
