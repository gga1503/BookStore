<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateGenre.aspx.cs" Inherits="GracielaBookStore.View.Administrator.Update_Genre.UpdateGenre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .content {
            margin-top: 10px;
        }
        h3{
            font-size:20pt;
            margin-top:10px;
        }
    </style>
    
    <div class="nav">
        <asp:Button class="nav-button" ID="HomeButton" runat="server" Text="Home" OnClick="HomeButton_Click" />
        <asp:Button class="nav-button" ID="ProfileButton" runat="server" Text="View Profile" OnClick="ProfileButton_Click" />
        <asp:Button class="nav-button" ID="ViewBooksButton" runat="server" Text="View Books" OnClick="ViewBooksButton_Click" />
        <asp:Button class="nav-button" ID="ViewUsersButton" runat="server" Text="View Users" OnClick="ViewUsersButton_Click" />
        <asp:Button class="nav-button" ID="ViewGenresButton" runat="server" Text="View Genres" OnClick="ViewGenresButton_Click" />
        <asp:Button class="nav-button" ID="InsertBookButton" runat="server" Text="Insert Book" OnClick="InsertBookButton_Click" />
        <asp:Button class="nav-button" ID="InsertGenreButton" runat="server" Text="Insert Genre" />
        <asp:Button class="nav-button" Style="float: right;" ID="LogoutButton" runat="server" Text="Logout" OnClick="LogoutButton_Click" />
    </div>
    
    <div class="content">
        <div>
            <h3>Update Book</h3>
        </div>
        <br />
       <div class="genrename">
            <asp:Label Text="Name" Width="130px" runat="server"></asp:Label>
            <asp:TextBox ID="GenreNameInput" runat="server"></asp:TextBox>
            <asp:Label ID="GenreName" runat="server" ForeColor="#ff6600" Text=" *Minimal length is 3 characters"></asp:Label>
        </div>
        <br />

        <div>
            <asp:Label ID="Description" Width="130px" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="DescriptionInput" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:Label ID="DescriptionNote" runat="server" ForeColor="#ff6600" Text=" *Minimal length is 10 characters"></asp:Label>
        <br />
        </div>
        <br />
        <asp:Label runat="server" ID="errorMessage" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click1"/>
    </div>
</asp:Content>
