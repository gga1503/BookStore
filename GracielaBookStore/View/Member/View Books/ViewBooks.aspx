<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewBooks.aspx.cs" Inherits="GracielaBookStore.View.Member.View_Books.ViewBooks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .content {
            margin-top: 10px;
        }

        h4 {
            font-size: 20pt;
            margin-top: 10px;
        }
    </style>
    <div class="nav">
        <asp:Button class="nav-button" ID="HomeButton" runat="server" Text="Home" OnClick="HomeButton_Click" />
        <asp:Button class="nav-button" ID="ProfileButton" runat="server" Text="View Profile" OnClick="ProfileButton_Click" />
        <asp:Button class="nav-button" ID="ViewBooksButton" runat="server" Text="View Books" />
        <asp:Button class="nav-button" ID="ViewUsersButton" runat="server" Text="View Users" OnClick="ViewUsersButton_Click" />
        <asp:Button class="nav-button" ID="ViewGenresButton" runat="server" Text="View Genres" OnClick="ViewGenresButton_Click" />
        <asp:Button class="nav-button" ID="InsertBookButton" runat="server" Text="Insert Book" OnClick="InsertBookButton_Click" />
        <asp:Button class="nav-button" ID="InsertGenreButton" runat="server" Text="Insert Genre" OnClick="InsertGenreButton_Click" />
        <asp:Button class="nav-button" Style="float: right;" ID="LogoutButton" runat="server" Text="Logout" OnClick="LogoutButton_Click" />
    </div>

    <div class="content">
        <h4>View Book</h4>
        <br />
        <div id="ProductDataTable" class="w-100" runat="server">
            <div class="col-md-12">
                <div class="container">
                    <asp:Table ID="BookTable" class="table table-bordered text-center" runat="server" Width="1000px">
                        <asp:TableHeaderRow>
                            <asp:TableHeaderCell>No.</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Book Name</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Genre</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Description</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Stock</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Price</asp:TableHeaderCell>
                            <asp:TableHeaderCell ID="Actiontable" ColumnSpan="2"> Action </asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                    </asp:Table>
                </div>
            </div>
        </div>
            <br /><br />
        <div>
            <asp:Button ID="ButtonInsert" runat="server" Text="Insert Book" OnClick="ButtonInsert_Click" />
        </div>
        
    </div>
</asp:Content>
