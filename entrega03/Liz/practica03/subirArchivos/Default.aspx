<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="subirArchivos._Default"  enableEventValidation="true"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        <pages enableEventValidation="true"/>
        input, select, textarea {
    max-width: 880px !important;
}
    </style>
   <h1> Seleccionar archivo</h1>
    <asp:FileUpload ID="FileUpload1" runat="server"  AllowMultiple="true" />
    <br />
    <asp:Label ID="Label1" runat="server" Text=" El archivo ya fue subido con anterioridad" Visible="false"></asp:Label>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click" />
    <br />
    <asp:Label ID="Label2" runat="server" Text=" Las siguientes filas no se pudieron procesar" Visible="false"></asp:Label>
    <br />
    <asp:ListBox ID="ListBox1" runat="server" Visible="false" Enabled="False" SelectionMode="Multiple"></asp:ListBox>
    <br />
    <asp:Button ID="Button2" runat="server" Visible="false" Text="Exportar" OnClick="Button2_Click" />
    
</asp:Content>
