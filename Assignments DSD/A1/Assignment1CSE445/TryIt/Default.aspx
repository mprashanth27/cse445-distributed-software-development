<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="From C to F" OnClick="Button1_Click"/>
    <asp:Label ID="Label1" runat="server" Text="Result here"></asp:Label><br />

    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="From F to C" OnClick="Button2_Click"/>
    <asp:Label ID="Label2" runat="server" Text="Result here"></asp:Label><br />
    
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button3" runat="server" Text="Sort String" OnClick="Button3_Click"/><br />
    <asp:Label ID="Label3" runat="server" Text="Sorted String here"></asp:Label><br />




</asp:Content>
