<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="GracielaBookStore.View.Member.Update_Profile.UpdateProfile" %>

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
        <asp:button class="nav-button" id="HomeButton" runat="server" text="Home" onclick="HomeButton_Click" />
        <asp:button class="nav-button" id="ProfileButton" runat="server" text="View Profile" onclick="ProfileButton_Click" />
        <asp:button class="nav-button" id="ViewBooksButton" runat="server" text="View Books" onclick="ViewBooksButton_Click" />
        <asp:button class="nav-button" id="ViewUsersButton" runat="server" text="View Users" onclick="ViewUsersButton_Click" />
        <asp:button class="nav-button" id="ViewGenresButton" runat="server" text="View Genres" onclick="ViewGenresButton_Click" />
        <asp:button class="nav-button" id="InsertBookButton" runat="server" text="Insert Book" onclick="InsertBookButton_Click" />
        <asp:button class="nav-button" id="InsertGenreButton" runat="server" text="Insert Genre" />
        <asp:button class="nav-button" style="float: right;" id="LogoutButton" runat="server" text="Logout" onclick="LogoutButton_Click" />
    </div>

    <div class="content">
        <div>
            <h3>Update Profile</h3>
        </div>
         <asp:Label ID="NameLabel" Width="160px" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="NameInput" runat="server"></asp:TextBox>
        <asp:Label ID="NameNote" runat="server" ForeColor="#ff6600" Text=" *Cannot be empty"></asp:Label>
        <br />

         <asp:Label ID="GenderLabel" Width="160px" runat="server" Text="Gender"></asp:Label>
        <asp:DropDownList ID="GenderInput" Width="100px" runat="server">
            <asp:ListItem Enabled="true" Text="Male" Value="1"></asp:ListItem>
            <asp:ListItem Text="Female" Value="2"></asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="GenderNote" runat="server" ForeColor="#ff6600" Style="margin-left: 160px" Text=" *Must be chosen"></asp:Label>
        <br />

        <asp:Label ID="PhoneNumberLabel" Width="160px" runat="server" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="PhoneNumberInput" runat="server"></asp:TextBox>
        <asp:Label ID="PhoneNumberNote" runat="server" ForeColor="#ff6600" Text=" *Must be numeric"></asp:Label>
        <br />

        <asp:Label ID="AddressLabel" Width="160px" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="AddressInput" runat="server"></asp:TextBox>
        <asp:Label ID="AddressNote" runat="server" ForeColor="#ff6600" Text=" *Must contain the word: Street"></asp:Label>
        <br />

        <asp:Label runat="server" ID="errorMessage" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Button ID="UpdateButton" runat="server" Text="Update"/>

    </div>
</asp:Content>
