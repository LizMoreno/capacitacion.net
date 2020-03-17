<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Listado de usuarios </h2>

        &nbsp;
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="535px" autogeneratecolumns="False" Height="158px" OnRowCommand="GridView1_RowCommand">
            <Columns> 
        <asp:BoundField DataField="Id" HeaderText="Id" Visible="True" ReadOnly="True" SortExpression="Id" />
        <asp:BoundField DataField="Nombre" HeaderText="Nombre"  SortExpression="Nombre" />
        <asp:BoundField DataField="Email" HeaderText="Email"      SortExpression="Email" />
        <asp:BoundField DataField="Password" HeaderText="Password"      SortExpression="Password" />
        <asp:BoundField DataField="Active" HeaderText="Active"      SortExpression="Active" />
        <asp:buttonfield buttontype="Button"  commandname="Editar"    text="Editar"/>
        <asp:buttonfield buttontype="Button"  commandname="Eliminar"    text="Eliminar"/>
    </Columns>
        </asp:GridView><br />
        <asp:Button ID="Agregar" runat="server" Height="28px" OnClick="Agregar_Click" Text="Agregar" Width="99px" />
    </div>

</asp:Content>
