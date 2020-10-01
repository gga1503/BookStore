<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="GracielaBookStore.View.Member.View_Profile.ViewProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .content {
            margin-top: 10px;
        }

        h3 {
            font-size: 20pt;
            margin-top: 10px;
        }
    </style>

    <div class="nav">
        <asp:Button class="nav-button" ID="HomeButton" runat="server" Text="Home" OnClick="HomeButton_Click" />
        <asp:Button class="nav-button" ID="ProfileButton" runat="server" Text="View Profile" />
        <asp:Button class="nav-button" ID="ViewBooksButton" runat="server" Text="View Books" OnClick="ViewBooksButton_Click" />
        <asp:Button class="nav-button" ID="ViewUsersButton" runat="server" Text="View Users" OnClick="ViewUsersButton_Click" />
        <asp:Button class="nav-button" ID="ViewGenresButton" runat="server" Text="View Genres" OnClick="ViewGenresButton_Click" />
        <asp:Button class="nav-button" ID="InsertBookButton" runat="server" Text="Insert Book" OnClick="InsertBookButton_Click" />
        <asp:Button class="nav-button" ID="InsertGenreButton" runat="server" Text="Insert Genre" OnClick="InsertGenreButton_Click" />
        <asp:Button class="nav-button" Style="float: right;" ID="LogoutButton" runat="server" Text="Logout" OnClick="LogoutButton_Click" />
    </div>


    <div class="content">
        <div>
            <h3>Profile</h3>
        </div>

        <div id="ProfileDataTable" class="w-100" runat="server">
            <div class="col-md-12">
                <div class="container">
                    <asp:Table ID="ProfileTable" class="table table-bordered text-center" runat="server" Width="1000px">
                        <asp:TableHeaderRow>
                            <asp:TableHeaderCell>Username</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Gender</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Phone Number</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Address</asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                    </asp:Table>
                </div>
            </div>
        </div>

        <br />
        <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click"/>
        <br /><br />
        <asp:Button ID="ChangePassword" runat="server" Text="Change Password" OnClick="ChangePassword_Click"/>
    </div>
</asp:Content>
