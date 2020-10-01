<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="GracielaBookStore.View.Administrator.Update_Book.Update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .content {
            margin-top: 10px;
        }
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
        <div>
            <h5>Update Book</h5>
        </div>
        <br />
        <div>
            <br />
            <asp:Label runat="server" Text="Book Id" Width="130px"></asp:Label>
            <asp:TextBox ID="UpdateBook" runat="server"></asp:TextBox>
            
        </div>
        <br />
        <div class="bookname">
            <asp:Label Text="Name" Width="130px" runat="server"></asp:Label>
            <asp:TextBox ID="BookNameInput" runat="server"></asp:TextBox>
        </div>
        <br />
        <div class="bookgenre">
            <asp:Label Text="Genre" Width="130px" runat="server"></asp:Label>
            <asp:DropDownList ID="BookGenre" Width="190px" runat="server">
                <asp:ListItem Enabled="true" Text="Fantasy" Value="1"></asp:ListItem>
                <asp:ListItem Text="Drama" Value="2"></asp:ListItem>
                <asp:ListItem Text="Mystery fiction" Value="3"></asp:ListItem>
                <asp:ListItem Text="Thriller " Value="4"></asp:ListItem>
                <asp:ListItem Text="Realistic Fiction " Value="5"></asp:ListItem>
                <asp:ListItem Text="High fantasy " Value="6"></asp:ListItem>
                <asp:ListItem Text="Speculative fiction " Value="7"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Description" Width="130px" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="DescriptionInput" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:Label ID="DescriptionNote" runat="server" ForeColor="#ff6600" Text=" *Minimal length is 10 characters"></asp:Label>
            <br />
        </div>

        <br />
        <div>
            <asp:Label Text="Stock" Width="130px" runat="server"></asp:Label>
            <asp:TextBox ID="BookStock" runat="server"></asp:TextBox>
            <asp:Label ID="BookStockNote" runat="server" ForeColor="#ff6600" Text=" *Must be numeric"></asp:Label>
        </div>

        <br />
        <div>
            <asp:Label Text="Price" Width="130px" runat="server"></asp:Label>
            <asp:TextBox ID="BookPrice" runat="server"></asp:TextBox>
            <asp:Label ID="PriceNote" runat="server" ForeColor="#ff6600" Text=" *Must be numeric"></asp:Label>
        </div>
        <br />
        <asp:Label runat="server" ID="errorMessage" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click"/>
    </div>

</asp:Content>
