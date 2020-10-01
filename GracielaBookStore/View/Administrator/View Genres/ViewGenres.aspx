<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewGenres.aspx.cs" Inherits="GracielaBookStore.View.Administrator.View_Genres.ViewGenres" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .content {
            margin-top: 10px;
        }

        h2 {
            font-size: 20pt;
            margin-top: 10px;
        }
    </style>

    <div class="nav">
        <asp:Button class="nav-button" ID="HomeButton" runat="server" Text="Home" OnClick="HomeButton_Click" />
        <asp:Button class="nav-button" ID="ProfileButton" runat="server" Text="View Profile" OnClick="ProfileButton_Click" />
        <asp:Button class="nav-button" ID="ViewBooksButton" runat="server" Text="View Books" OnClick="ViewBooksButton_Click" />
        <asp:Button class="nav-button" ID="ViewUsersButton" runat="server" Text="View Users" OnClick="ViewUsersButton_Click" />
        <asp:Button class="nav-button" ID="ViewGenresButton" runat="server" Text="View Genres" />
        <asp:Button class="nav-button" ID="InsertBookButton" runat="server" Text="Insert Book" OnClick="InsertBookButton_Click" />
        <asp:Button class="nav-button" ID="InsertGenreButton" runat="server" Text="Insert Genre" OnClick="InsertGenreButton_Click" />
        <asp:Button class="nav-button" Style="float: right;" ID="LogoutButton" runat="server" Text="Logout" OnClick="LogoutButton_Click" />
    </div>


    <div class="content">
        <h2>View Genres </h2>

        <br />
        <div id="GenreDataTable" class="w-100" runat="server">
            <div class="col-md-12">
                <div class="container">
                    <asp:Table ID="GenreTable" class="table table-bordered text-center" runat="server" Width="1000px">
                        <asp:TableHeaderRow>
                            <asp:TableHeaderCell>No.</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Genre Name</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Description</asp:TableHeaderCell>
                            <asp:TableHeaderCell ColumnSpan="2"> Action </asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                    </asp:Table>
                </div>
            </div>
        </div>
        <br />
        <br />
        <div>
            <asp:Button ID="ButtonInsert" runat="server" Text="Insert Genre" OnClick="ButtonInsert_Click" />
        </div>
    </div>
</asp:Content>
