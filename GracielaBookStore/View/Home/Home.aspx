<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="GracielaBookStore.View.Member.Home.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        h2{
            text-align: center;
            font-size:20pt;
            margin-top:10px;
        }
        p{
            text-align: center;
            font-size:12pt;
        }
    </style>
    <div class="nav">
        <asp:Button class="nav-button" ID="HomeButton" runat="server" Text="Home"/>
        <asp:Button class="nav-button" ID="ProfileButton" runat="server" Text="View Profile" OnClick="ProfileButton_Click" />
        <asp:Button class="nav-button" ID="ViewBooksButton" runat="server" Text="View Books" OnClick="ViewBooksButton_Click" />
        <asp:Button class="nav-button" ID="ViewUsersButton" runat="server" Text="View Users" OnClick="ViewUsersButton_Click" />
        <asp:Button class="nav-button" ID="ViewGenresButton" runat="server" Text="View Genres" OnClick="ViewGenresButton_Click" />
        <asp:Button class="nav-button" ID="InsertBookButton" runat="server" Text="Insert Book" OnClick="InsertBookButton_Click" />
        <asp:Button class="nav-button" ID="InsertGenreButton" runat="server" Text="Insert Genre" OnClick="InsertGenreButton_Click" />
        <asp:Button class="nav-button" Style="float: right;" ID="LogoutButton" runat="server" Text="Logout" OnClick="LogoutButton_Click" />
    </div>
    <div class="content">
        <h2>Hi,<%=username%></h2>
        <p>Welcome to BookVendor !<br />
            Your dream start from here
        </p>

        


    </div>
</asp:Content>
