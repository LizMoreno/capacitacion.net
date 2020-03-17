<%@ Page Title="Hola mundo" Language="C#"  MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplicationTest.About" %>

<asp:Content ID="NehuenID" ContentPlaceHolderID="MainContent" runat="server">
     
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Despedida" />
    </p>
    <p>
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        \</p>
    <p>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Completa este campo" SetFocusOnError="True"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" Text="Enviar" />
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>
        <asp:Label ID="lblTexto" runat="server"></asp:Label>
    </p>
 
 
</asp:Content>
