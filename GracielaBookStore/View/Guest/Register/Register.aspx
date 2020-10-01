<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GracielaBookStore.View.Guest.Register.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        input {
            width: 250px;
        }
    </style>

    <div class="context">
        <div>
            <h2>Register</h2>
        </div>

        <asp:Label ID="UsernameLabel" Width="160px" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="UsernameInput" runat="server"></asp:TextBox>
        <asp:Label ID="UsernameNote" runat="server" ForeColor="#ff6600" Text=" *Minimal length is 3 characters"></asp:Label>
        <br />

        <asp:Label ID="EmailLabel" Width="160px" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="EmailInput" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="PasswordLabel" Width="160px" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="PasswordInput" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="PasswordNote" runat="server" ForeColor="#ff6600" Text=" *Minimal length is 8 characters"></asp:Label>
        <br />

        <asp:Label ID="ConfirmPasswordLabel" Width="160px" runat="server" Text="Confirm Password"></asp:Label>
        <asp:TextBox ID="PasswordConfirmInput" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="ConfirmPasswordNote" runat="server" ForeColor="#ff6600" Text=" *Must be the same as the inputted password"></asp:Label>
        <br />

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
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
    </div>


</asp:Content>
