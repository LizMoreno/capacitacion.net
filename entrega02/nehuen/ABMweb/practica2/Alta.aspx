<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alta.aspx.cs" Inherits="practica2.Alta" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <h1>Alta de usuario.</h1>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextUser" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextMail" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    </p>
    <p>Contraseña:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextPass" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click1" />
    </p>
   
   
</asp:Content>
